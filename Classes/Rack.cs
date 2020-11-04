using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace RackKeyV07
{
    public class Rack
    {
        public Control control;       
        public Point Location;
        public int u_size;
        public Image rackPicture;
        public string ImageLocation;
        public Component[] components;
        public string name;
        public int RackID;
        public static int RackSum = 0;
        #region C'tors

        public Rack()
        {
            RackSum++;
            this.RackID = RackSum;
        }

        public Rack(int u, string name, string imgPath, Point p):
            this()
        {
            this.u_size = u;
            this.name = name;
            this.Location = p;
            if (imgPath != null && imgPath!= "")
            {
                this.rackPicture = Project.GetCorrectedImage(imgPath);
            }
            control = new Control();
            control.Location = p;
                        this.control.Size = Globs.RackButtonSize;

            components = new Component[u_size];
        }


        public Rack(int u, string name, string imgPath, Point p,int id):
            this()
        {
            this.RackID = id;
            this.u_size = u;
            this.name = name;
            this.Location = p;
            if (imgPath != "")
            {
                this.rackPicture = Project.GetCorrectedImage(imgPath);
            }
            control = new Control();
            this.control.Size = Globs.RackButtonSize;
            control.Location = p;
            components = new Component[u_size];
        }

        public Rack(int u, string name, string imgPath, Point p, int id,int height,int Width) :
            this()
        {
            this.RackID = id;
            this.u_size = u;
            this.name = name;
            this.Location = p;
            if (imgPath != "")
            {
                this.rackPicture = Project.GetCorrectedImage(imgPath);
            }
            control = new Control();

            this.control.Height = height;
            this.control.Width = Width;
            control.Location = p;
            components = new Component[u_size];
        }
        #endregion

        public void SetControl(Control control)
        {
            this.control = control;
        }


        public void DeleteImage()
        {
            if (File.Exists(this.ImageLocation))
            {
                File.Delete(this.ImageLocation);
            }
        }
        #region Components Functions
        public Component FindComponent(PictureBox pb)
        {
            for (int i = 0; i < components.Length; i++)
            {
                if (components[i]!=null)
                {
                    if (components[i].PictureBox == pb)
                    {
                        return components[i];
                    }
                }
            }
            return null;
        }
        public void AddComponent(Component component)
        {
            components[component.rackIndex] = component;
            component.ComponentID = component.GetComponentID();
            string sql = "Insert Into Components(ComponentID,UIndex,ComponentType,ComponentDescription,UnderRack) Values({0},{1},'{2}','{3}','{4}')";
            string buildedsql = String.Format(sql,component.ComponentID, component.rackIndex, component.ComponentType.ID.ToString(), component.descriptionLabelText, this.RackID);
            Globs.DB.Insert(buildedsql);
        }
        public void RemoveComponent(Component component)
        {

            string sql = "Delete FROM Components Where ComponentID=" + component.ComponentID;
            Globs.DB.Delete(sql);
            components[component.rackIndex] = null ;
        }
        public void LoadComponents()
        {

            string SelectSql = "Select * From Components Where UnderRack=" + this.RackID;
            DataTable dt = Globs.DB.Select(SelectSql);
            foreach (DataRow dr in dt.Rows)
            {
                int Componentid = (int)dr["ComponentID"];
                int index = (int)dr["UIndex"];
                int type = (int)dr["ComponentType"];
                string text = dr["ComponentDescription"].ToString();
                ComponentType ct = Globs.main.GetComponentType(type);
                if (ct == null)
                    {
                        MessageBox.Show("Couldnt Find Component type: '" + type + "' For Component: " + Componentid);
                    }
                else
                    {
                        Component loadedComponent = new Component(ct, index, text, Componentid);
                        components[index] = loadedComponent;
                    }
            }
        }

        #endregion

    }
}
