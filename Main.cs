using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using MetroFramework.Controls;
using System.Runtime.CompilerServices;
using System.Drawing.Imaging;

namespace RackKeyV07
{
    public class Main
    {
        public static List<ComponentType> componentTypes = new List<ComponentType>();
        public static List<Rack> NetworkRacks = new List<Rack>();
        public static List<AreaPicture> Areas = new List<AreaPicture>();
        public static List<Decoration> Decorations = new List<Decoration>();

        public Main()
        {
        }

        #region ComponentTypes List Functions
        public static void AddComponentType(ComponentType newType)
        {
            componentTypes.Add(newType);
            string sql = "Insert Into ComponentTypes(ID,TypeName,PictureLocation,Usize) Values({0},'{1}','{2}',{3})";
            string buildedSql = string.Format(sql,newType.ID, newType.TypeName, Path.GetFileName(newType.ImageLocation), newType.USize);
            Globs.DB.Insert(buildedSql);
        }
        public static void LoadTypes()
        {

            string sql = "Select * FROM ComponentTypes";
            try
            {
                DataTable dt = Globs.DB.Select(sql);
                foreach (DataRow dataRow in dt.Rows)
                {
                    int ID = (int)dataRow["ID"];
                    int size_u = (int)dataRow["Usize"];
                    string typeName = dataRow["TypeName"].ToString();
                    string imagepath = Globs.CurrentProject.ProjectImageFolderPath + dataRow["PictureLocation"].ToString();
                    if (File.Exists(imagepath))
                    {
                        ComponentType type = new ComponentType(typeName, imagepath, size_u);
                        type.ID = ID;
                        componentTypes.Add(type);
                    }
                    else
                    {
                        MessageBox.Show("Cant Find Picture File For component type " + typeName + " at " + imagepath);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                System.Windows.Forms.Application.Exit();
            }
        }
        public static void RemoveType(ComponentType toRemove)
        {
            toRemove.DeleteImage();
            string sql = "Delete FROM ComponentTypes Where ID=" + toRemove.ID;
            Globs.DB.Delete(sql);
            componentTypes.Remove(toRemove);
        }
        public static void UpdateComponentType(ComponentType toUpdate)
        {
            string sql = "Update ComponentTypes SET TypeName='" + toUpdate.TypeName + "' , PictureLocation='"+Path.GetFileName(toUpdate.ImageLocation)+"',Usize=" + toUpdate.USize+ " WHERE ID=" + toUpdate.ID;
            Globs.DB.Update(sql);
        }
        /// <summary>
        /// Get Component Type By Name
        /// </summary>
        public ComponentType GetComponentType(string name)
        {
            foreach (ComponentType item in componentTypes)
            {
                if (item.TypeName == name)
                {
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Get Component Type By index number
        /// </summary>
        /// <param name="id"> index presents the component type</param>
        /// <returns> Component Type </returns>
        public ComponentType GetComponentType(int id)
        {
            foreach (ComponentType item in componentTypes)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
        #endregion

        #region Rack List Functions
        public void LoadRacks()
        {

            string sql = "Select * FROM Racks";
            try
            {
                DataTable dt = Globs.DB.Select(sql);
                foreach (DataRow dataRow in dt.Rows)
                {
                    int rackId = (int)dataRow["RackID"];
                    int size_u = (int)dataRow["Usize"];
                    int ControlWidth = (int)dataRow["ControlWidth"];
                    int ControlHeight = (int)dataRow["ControlHeight"];
                    string rackName = dataRow["RackName"].ToString();
                    Point p = new Point((int)dataRow["Xlocation"], (int)dataRow["Ylocation"]);
                    string imagepath = "";
                    Image img = null;
                    if (dataRow["ImageLocation"].ToString() != "")
                    {
                        imagepath = Globs.CurrentProject.ProjectImageFolderPath + dataRow["ImageLocation"].ToString();
                        if (File.Exists(imagepath))
                        {
                            img = Project.GetCorrectedImage(imagepath);
                        }
                        else
                        {
                            MessageBox.Show("לא נמצאה התמונה עבור ארון " + rackName);
                        }
                    }
                    Rack rack = new Rack(size_u, rackName, imagepath, p,rackId,ControlHeight,ControlWidth);
                    NetworkRacks.Add(rack);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                System.Windows.Forms.Application.Exit();
            }

            LoadComponentsForRacks();
        }
        public void LoadComponentsForRacks()
        {
            foreach (Rack item in NetworkRacks)
            {
                item.LoadComponents();
            }
        }
    
        public static void AddNewRack(Rack rk)
        {
            rk.RackID = Main.AvailableRackID();
            NetworkRacks.Add(rk);
            string sql = "Insert Into Racks(RackID,RackName,Xlocation,Ylocation,ImageLocation,Usize,ControlWidth,ControlHeight) Values({0},'{1}',{2},{3},'{4}',{5},{6},{7})";
            string buildedsql = String.Format(sql, rk.RackID, rk.name, rk.Location.X, rk.Location.Y,Path.GetFileName(rk.ImageLocation),rk.u_size,rk.control.Width,rk.control.Height);
            Globs.DB.Insert(buildedsql);
        }
        public static void UpdateRacKSize(Rack rk, Control rackControl)
        {
            string sql = "Update Racks SET ControlWidth='" + rackControl.Width + "',ControlHeight='"+rackControl.Height+"' WHERE RackID=" + rk.RackID;
            Globs.DB.Update(sql);
        }
        public static void UpdateRackName(Rack rk, string newname)
        {
            string sql = "Update Racks SET RackName='" + newname + "' WHERE RackID=" + rk.RackID;
            Globs.DB.Update(sql);
        }
        public void SetRackImage(string filepath,Rack rk)//Set Rack Image
        {
            if (filepath != "")
            {
                if (File.Exists(filepath))
                {
                    rk.DeleteImage();
                    string newPath = Globs.CurrentProject.CopyImageGetPath(filepath,"Rack"+rk.RackID+Path.GetExtension(filepath));                    
                    Image img = Project.GetCorrectedImage(newPath);
                    string sql = "Update Racks SET ImageLocation='" + Path.GetFileName(newPath) + "' WHERE RackID=" + rk.RackID;
                    Globs.DB.Update(sql);
                    rk.ImageLocation = newPath;
                    rk.rackPicture = img;

                }
            }
        }

        public static void RemoveRack(Rack Rk)
        {
            string sql = "Delete FROM Racks Where RackID=" + Rk.RackID;
            Globs.DB.Delete(sql);
            Rk.DeleteImage();
            NetworkRacks.Remove(Rk);
        }
        public List<Rack> GetRacksList()
        {
            return NetworkRacks;
        }


        public static void UpdateAllRacksLocAndSize()
        {
            foreach (var item in NetworkRacks)
            {

                string sql = "Update Racks SET ControlHeight=" + item.control.Height + ", ControlWidth=" + item.control.Width + ", Xlocation=" + item.control.Location.X + ", Ylocation=" + item.control.Location.Y + " WHERE RackID=" + item.RackID;
                Globs.DB.Update(sql);
            }
        }

        #endregion

        #region Area List Functions
        public static void LoadAreas()
        {
            string sql = "Select * FROM AirPictures";
            try
            {
                DataTable dt = Globs.DB.Select(sql);
                foreach (DataRow dataRow in dt.Rows)
                {
                    int id = (int)dataRow["ID"];
                    int height = (int)dataRow["Height"];
                    int width = (int)dataRow["Width"];
                    Size s = new Size(width, height);
                    int x = (int)dataRow["X"];
                    int y = (int)dataRow["Y"];
                    Point point = new Point(x, y);
                    string picLoc =Globs.CurrentProject.ProjectImageFolderPath+ dataRow["PictureLocation"].ToString();
                    Panel panel = new Panel();
                    panel.Location = point;
                    panel.Size = s;
                    AreaPicture areaPicture = new AreaPicture(panel, picLoc);
                    areaPicture.ID = id;                    
                    areaPicture.panelArea.SendToBack();
                    Areas.Add(areaPicture);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                System.Windows.Forms.Application.Exit();
            }
        }
        public static void AddAreas(AreaPicture area)
        {
            area.ID = Main.AvailableAreaID();
            Areas.Add(area);
            string sql = "Insert Into AirPictures(ID,Height,Width,X,Y,PictureLocation) Values({0},{1},{2},{3},{4},'{5}')";
            string buildedSql = string.Format(sql,area.ID, area.panelArea.Height, area.panelArea.Width, area.panelArea.Location.X, area.panelArea.Location.Y, Path.GetFileName(area.ImageLocation));
            Globs.DB.Insert(buildedSql);
        }
        public void TurnAllVisible(ContextMenuStrip ctx)
        {
            foreach (AreaPicture item in Areas)
            {
                item.SetVisibleTrue(ctx);
            }
        }
        public void TurnAlInvisible()
        {
            foreach (AreaPicture item in Areas)
            {
                item.SetInvisible();

            }
        }
        public void RemoveArea(AreaPicture area)
        {
            area.DeleteImage();
            string sql = "Delete FROM AirPictures Where ID=" + area.ID;
            Globs.DB.Delete(sql);
            Areas.Remove(area);
        }
        public AreaPicture GetAreaByPanel(Panel panel)
        {
            foreach (AreaPicture item in Areas)
            {
                if (item.panelArea == panel)
                {
                    return item;
                }
            }
            return null;
        }

        public static void UpdateAllAreaLocAndSize()
        {
            foreach (var item in Areas)
            {
                string sql = "Update AirPictures SET Height=" + item.panelArea.Height + ", Width=" + item.panelArea.Width + ", X=" + item.panelArea.Location.X + ", Y=" + item.panelArea.Location.Y + " WHERE ID=" + item.ID;
                Globs.DB.Update(sql);
            }
        }
        #endregion

        #region Decorations List Functions
        public static void AddDecoration(Decoration decoration)
        {
            Decorations.Add(decoration);
            decoration.id = AvailableDecorationID();
            string sql = "Insert Into Decorations(ID,Type,X,Y,Width,Height,RotationAngle) Values({0},{1},{2},{3},{4},{5},{6})";
            string buildedSql = string.Format(sql,decoration.id, (int)decoration.type,decoration.picture.Location.X,decoration.picture.Location.Y,decoration.picture.Width,decoration.picture.Height,decoration.angle);
            Globs.DB.Insert(buildedSql);
        }

        public static void LoadDecorations()
        {


            string sql = "Select * FROM Decorations";
            try
            {
                DataTable dt = Globs.DB.Select(sql);
                foreach (DataRow dataRow in dt.Rows)
                {
                    int id = (int)dataRow["ID"];
                    DecorationType type = (DecorationType)((int)dataRow["Type"]);
                    Point p = new Point((int)dataRow["X"], (int)dataRow["Y"]);
                    Size s = new Size((int)dataRow["Width"], (int)dataRow["Height"]);
                    int angel = (int)dataRow["RotationAngle"];
                    
                    Decoration decoration = new Decoration(type, p, s,angel);
                    decoration.SetAngle(angel);
                    decoration.id = id;
                    Decorations.Add(decoration);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                System.Windows.Forms.Application.Exit();
            }
        }

        public static void RemoveDecoration(Decoration toRemove)
        {
            string sql = "Delete FROM Decorations Where ID=" + toRemove.id;
            Globs.DB.Delete(sql);
            Decorations.Remove(toRemove);
        }
        public static Decoration GetDecorationByPicture(PictureBox picture)
        {
            foreach (var item in Decorations)
            {
                if (item.picture == picture)
                {
                    return item;

                }
            }
            return null;
        }

        public static void UpdateAllDecorationLocAndSize()
        {
            foreach (var item in Decorations)
            {

                string sql = "Update Decorations SET Height=" + item.picture.Height + ", Width=" + item.picture.Width + ", X=" + item.picture.Location.X + ", Y=" + item.picture.Location.Y +", RotationAngle="  + item.angle +  " WHERE ID=" + item.id;
                Globs.DB.Update(sql);
            }
        }

        #endregion

        #region Get Id Numbers

        public static int AvailableAreaID()
        {
            int areaSum = AreaPicture.sum;//Get Number of Components in all racks
            string SelectSql = "Select * From AirPictures";
            DataTable dt = Globs.DB.Select(SelectSql);//Get datatable from the db of the components with all info
            int max = 0;
            foreach (DataRow dataRow in dt.Rows)
            {
                if (max < (int)dataRow["ID"])
                {
                    max = (int)dataRow["ID"];
                }
            }
            bool[] IdTaken = new bool[max + 1];

            foreach (DataRow dataRow in dt.Rows)
            {
                IdTaken[(int)dataRow["ID"]] = true;
            }
            for (int j = 0; j < IdTaken.Length; j++)
            {
                if (!IdTaken[j])
                {
                    return j;
                }
            }
            return areaSum;
        }

        public static int AvailableRackID()
        {
            int sumOfAllComponets = Rack.RackSum;//Get Number of Components in all racks
            string SelectSql = "Select * From Racks";
            DataTable dt = Globs.DB.Select(SelectSql);//Get datatable from the db of the components with all info
            int max = 0;
            foreach (DataRow dataRow in dt.Rows)
            {
                if (max < (int)dataRow["RackID"])
                {
                    max = (int)dataRow["RackID"];
                }
            }
            bool[] IdTaken = new bool[max + 1];

            foreach (DataRow dataRow in dt.Rows)
            {
                IdTaken[(int)dataRow["RackID"]] = true;
            }
            for (int j = 0; j < IdTaken.Length; j++)
            {
                if (!IdTaken[j])
                {
                    return j;
                }
            }
            return sumOfAllComponets;
        }
        public static int AvailableComponentID()
        {
            int sumOfAllComponets = Component.ComponentSum;//Get Number of Components in all racks
            string SelectSql = "Select * From Components";
            DataTable dt = Globs.DB.Select(SelectSql);//Get datatable from the db of the components with all info
            int max = 0;
            foreach (DataRow dataRow in dt.Rows)
            {
                if (max < (int)dataRow["ComponentID"])
                {
                    max = (int)dataRow["ComponentID"];
                }
            }
            bool[] IdTaken = new bool[max + 1];

            foreach (DataRow dataRow in dt.Rows)
            {
                IdTaken[(int)dataRow["ComponentID"]] = true;
            }
            for (int j = 0; j < IdTaken.Length; j++)
            {
                if (!IdTaken[j])
                {
                    return j;
                }
            }
            return sumOfAllComponets;
        }
        public static int AvailableDecorationID()
        {
            int sumOfAllComponets = Decoration.sumDecorations;//Get Number of Components in all racks
            string SelectSql = "Select * From Decorations";
            DataTable dt = Globs.DB.Select(SelectSql);//Get datatable from the db of the components with all info
            int max = 0;
            foreach (DataRow dataRow in dt.Rows)
            {
                if (max < (int)dataRow["ID"])
                {
                    max = (int)dataRow["ID"];
                }
            }
            bool[] IdTaken = new bool[max + 1];

            foreach (DataRow dataRow in dt.Rows)
            {
                IdTaken[(int)dataRow["ID"]] = true;
            }
            for (int j = 0; j < IdTaken.Length; j++)
            {
                if (!IdTaken[j])
                {
                    return j;
                }
            }
            return sumOfAllComponets;
        }
        public static int GetAvailableComponentTypeID()
        {
            int sumOfAllComponets = ComponentType.NumberOfTypes;//Get Number of Components in all racks
            string SelectSql = "Select * From ComponentTypes";
            DataTable dt = Globs.DB.Select(SelectSql);//Get datatable from the db of the components with all info
            int max = 0;
            foreach (DataRow dataRow in dt.Rows)
            {
                if (max < (int)dataRow["ID"])
                {
                    max = (int)dataRow["ID"];
                }
            }
            bool[] IdTaken = new bool[max + 1];

            foreach (DataRow dataRow in dt.Rows)
            {
                IdTaken[(int)dataRow["ID"]] = true;
            }
            for (int j = 0; j < IdTaken.Length; j++)
            {
                if (!IdTaken[j])
                {
                    return j;
                }
            }
            return sumOfAllComponets;
        }
        #endregion

        #region DataBase Functions
        public void SaveAll()
        {            
            UpdateAllRacksLocAndSize();
            UpdateAllAreaLocAndSize();
            UpdateAllDecorationLocAndSize();
            MessageBox.Show("שמירה עברה בהצלחה");
        }
        public void DeleteAll()
        { }

        public static List<Component> GetComponentsList()
        {
            List<Component> AllComponents = new List<Component>();
            string sql = "Select * FROM Components";
            try
            {
                DataTable dt = Globs.DB.Select(sql);
                foreach (DataRow dataRow in dt.Rows)
                {
                    int compId = (int)dataRow["ComponentID"];
                    int Uindex = (int)dataRow["UIndex"];
                    string Type = dataRow["ComponentType"].ToString();
                    string Description = dataRow["ComponentDescription"].ToString();
                    int UnderRack = (int)dataRow["UnderRack"];
                    ComponentType ct = Globs.main.GetComponentType(Type);
                    Component comp = new Component(ct, Uindex, Description, compId);
                    AllComponents.Add(comp);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return AllComponents;
        }
        #endregion


        public void CorrectExifOrientation(Image image)
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
        }//if the picture is rotated should fix it

    }
}
