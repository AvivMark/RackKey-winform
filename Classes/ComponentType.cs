using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace RackKeyV07
{
    public class ComponentType
    {
        public string TypeName;
        public Image image;
        public int USize;
        public string ImageLocation;
        public static int NumberOfTypes = 0;
        public int ID;
        public ComponentType(string Name,string imgPath,int Size)
        {
            this.TypeName = Name;
            this.USize = Size;
            this.ImageLocation = imgPath;
            this.image = Project.GetCorrectedImage(imgPath);
            NumberOfTypes++;
        }
        public override string ToString()
        {
            return TypeName;
        }
        public void DeleteImage()
        {
            File.Delete(ImageLocation);
        }
        public void SetTypeImage(string NewImagePath)
        {
            string ImageName = "Type"+ID + Path.GetExtension(NewImagePath);
            string AfterCopy = Globs.CurrentProject.CopyImageGetPath(NewImagePath, ImageName);
            this.ImageLocation = AfterCopy;
            this.image = Project.GetCorrectedImage(AfterCopy);
        }
    }
}
