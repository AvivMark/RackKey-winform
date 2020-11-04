using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Drawing.Imaging;

namespace RackKeyV07
{
    public class Project
    {
        public string ProjectLocationFolder;
        public static readonly string ProjectFileType = ".rky";
        public string ProjectName;
        public string ProjectDBfilePath;
        public string ProjectImageFolderPath;
        public string ZipFilePath;
        public Project(string path,bool Exist)
        {
            if (!Exist)
            {

                this.CreateProject(path);
            }
            try
            {
                this.OpenProject(path);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            
        }

        #region Handle Image
        public static Image GetCorrectedImage(string path)
        {
            int orientationId = 0x0112;
            try
            {
                Image img;
                Image GetExif;
                GetExif = System.Drawing.Image.FromFile(path);
                PropertyItem pi = null;
                if (GetExif!=null)
                {
                    if (GetExif.PropertyIdList.Contains(orientationId))
                        pi = GetExif.GetPropertyItem(orientationId);
                }
                GetExif.Dispose();
                using (Stream stream = File.OpenRead(path))
                {
                    img = Image.FromStream(stream);
                    if (pi != null && img != null)
                    {
                        img.SetPropertyItem(pi);
                        CorrectExifOrientation(img);
                    }
                }

                return img;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }
        private static void CorrectExifOrientation(Image image)
        {
            if (image == null) return;
            int orientationId = 0x0112;
            if (image.PropertyIdList.Contains(orientationId))
            {
                var orientation = (int)image.GetPropertyItem(orientationId).Value[0];
                var rotateFlip = RotateFlipType.RotateNoneFlipNone;
                switch (orientation)
                {
                    case 1: rotateFlip = RotateFlipType.RotateNoneFlipNone; break;
                    case 2: rotateFlip = RotateFlipType.RotateNoneFlipX; break;
                    case 3: rotateFlip = RotateFlipType.Rotate180FlipNone; break;
                    case 4: rotateFlip = RotateFlipType.Rotate180FlipX; break;
                    case 5: rotateFlip = RotateFlipType.Rotate90FlipX; break;
                    case 6: rotateFlip = RotateFlipType.Rotate90FlipNone; break;
                    case 7: rotateFlip = RotateFlipType.Rotate270FlipX; break;
                    case 8: rotateFlip = RotateFlipType.Rotate270FlipNone; break;
                    default: rotateFlip = RotateFlipType.RotateNoneFlipNone; break;
                }
                if (rotateFlip != RotateFlipType.RotateNoneFlipNone)
                {
                    image.RotateFlip(rotateFlip);
                    image.RemovePropertyItem(orientationId);
                }
            }
        }
        /// <summary>
        /// Copy Image to image folder location and return the image new path
        /// </summary>
        /// <param name="imagepath"> current image path</param>
        /// <param name="ImageName"> image filename</param>
        /// <returns></returns>
        public string CopyImageGetPath(string imagepath,string ImageName)
        {
            try
            {
                string NewImagePath = this.ProjectImageFolderPath + ImageName;
                if (File.Exists(NewImagePath))
                {
                    DeleteFile(NewImagePath);
                }
                File.Copy(imagepath, NewImagePath);

                return NewImagePath;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        #endregion

        #region Handle Zip File

        public void ZipProjectFolder()
        {
            ZipFile.CreateFromDirectory(this.ProjectLocationFolder, this.ZipFilePath);
        }
        public void UnzipProjectFolder()
        {            
            if (Directory.Exists(this.ProjectLocationFolder))
            {
                Directory.Delete(this.ProjectLocationFolder, true);
            }

            ZipFile.ExtractToDirectory(this.ZipFilePath, this.ProjectLocationFolder);

            try
            {
                MakeHiddenDirectory(this.ProjectLocationFolder);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion
        #region Handle Project Files        
        private void MakeHiddenDirectory(string path)
        {

            DirectoryInfo info = new DirectoryInfo(path);
            info.Attributes = FileAttributes.Hidden;
        }

        private void DeleteFile(string path)
        {
            File.Delete(path);
        }
        public void DeleteImageFile(string ImageName)
        {
            if (File.Exists(ProjectImageFolderPath + ImageName))
            {
                string fullPath = ProjectImageFolderPath + ImageName;
                DeleteFile(fullPath);
            }
        }
        #endregion

        #region Handle Setting

        public void MatchSettingToProject()
        {
            Properties.Settings.Default.ProjectName = this.ProjectName;
            Properties.Settings.Default.ProjectFolderLocation = this.ProjectLocationFolder;
            Properties.Settings.Default.ProjectImageFolder = this.ProjectImageFolderPath;
            Properties.Settings.Default.DBLocation = this.ProjectDBfilePath;
            Properties.Settings.Default.Save();
            Globs.DB = new DBHandler(this.ProjectDBfilePath);

        }

        public void MatchProjectToSettings()
        {
            this.ProjectName = Properties.Settings.Default.ProjectName;
            this.ProjectLocationFolder = Properties.Settings.Default.ProjectFolderLocation;
            this.ProjectImageFolderPath = Properties.Settings.Default.ProjectImageFolder;
            this.ProjectDBfilePath = Properties.Settings.Default.DBLocation;
        }
        #endregion
        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
        public void OpenProject(string path)
        {
            if (string.IsNullOrWhiteSpace(this.ZipFilePath))
            {
                if (path.Contains(ProjectFileType))
                {
                    this.ZipFilePath = path;
                }
            }
            this.ProjectLocationFolder = path.Replace(ProjectFileType, string.Empty);

            this.ProjectName = Path.GetFileNameWithoutExtension(path);
            this.ProjectDBfilePath = this.ProjectLocationFolder + @"\AppData\FarmDB.accdb";
            this.ProjectImageFolderPath = this.ProjectLocationFolder + "\\Media\\";
            UnzipProjectFolder();
            MatchSettingToProject();
            Globs.CurrentProject = this;
        }
        public void CreateProject(string path)
        {
            this.ProjectName = Path.GetFileNameWithoutExtension(path);
            this.ZipFilePath = path + ProjectFileType;
            this.ProjectLocationFolder = path;
            this.ProjectImageFolderPath = ProjectLocationFolder + "\\Media\\";
            Directory.CreateDirectory(ProjectImageFolderPath);
            this.ProjectDBfilePath = ProjectLocationFolder + @"\AppData";
            Directory.CreateDirectory(ProjectDBfilePath);
            string originalDB = AppDomain.CurrentDomain.BaseDirectory + @"\AppData\FarmDB.accdb";
            this.ProjectDBfilePath = ProjectLocationFolder + @"\AppData\FarmDB.accdb";
            File.Copy(originalDB, this.ProjectDBfilePath);
            this.ZipProjectFolder();
        }

          
        public void CloseProject()
        {
            try
            {
                File.Delete(this.ZipFilePath);
                this.ZipProjectFolder();            
                string[] files = Directory.GetFiles(this.ProjectLocationFolder);
                foreach (string file in files)
                {
                    FileInfo fileinfo = new FileInfo(file);
                    if (IsFileLocked(fileinfo))
                    {
                        
                        MessageBox.Show("File: " + fileinfo.Name + " Is locked");
                    }
                    else
                    {
                        File.Delete(file);
                    }
                    
                }
                Directory.Delete(this.ProjectLocationFolder, true);                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }
        public void MoveProject(string path)
        {

            this.ProjectName = Path.GetFileNameWithoutExtension(path);
            this.ZipFilePath = path + ProjectFileType;
            this.ProjectLocationFolder = path;
            this.ProjectImageFolderPath = ProjectLocationFolder + "\\Media\\";
            Directory.CreateDirectory(ProjectImageFolderPath);
            this.ProjectDBfilePath = ProjectLocationFolder + @"\AppData";
            Directory.CreateDirectory(ProjectDBfilePath);
            string originalDB = AppDomain.CurrentDomain.BaseDirectory + @"\AppData\FarmDB.accdb";
            this.ProjectDBfilePath = ProjectLocationFolder + @"\AppData\FarmDB.accdb";
            File.Copy(originalDB, this.ProjectDBfilePath);
            this.ZipProjectFolder();
            MakeHiddenDirectory(this.ProjectLocationFolder);
            Globs.CurrentProject = this;

        }

    }
}
