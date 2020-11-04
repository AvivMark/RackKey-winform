using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data;
namespace RackKeyV07
{
    public class Component
    {
        public string descriptionLabelText;
        public ComponentType ComponentType;
        public PictureBox PictureBox;
        public int rackIndex;
        public int ComponentID;
        public static int ComponentSum = 0;
        public Component(ComponentType componentType,string desc)
        {
            this.ComponentType = componentType;
            this.descriptionLabelText = desc;
            ComponentSum++;
            ComponentID = ComponentSum;

        }
        public Component(ComponentType componentType,int index,string text)
        {
            this.ComponentType = componentType;
            this.rackIndex = index;
            this.descriptionLabelText = text;

            ComponentSum++;
            ComponentID = ComponentSum;
        }

        public Component(ComponentType componentType, int index, string text,int id)
        {
            this.ComponentType = componentType;
            this.rackIndex = index;
            this.descriptionLabelText = text;
            this.ComponentID = id;
            ComponentSum++;
        }

        public int GetComponentID()
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

        public void SetPicBox(PictureBox PB)
        {
            this.PictureBox = PB;
        }
        public string GetDescription()
        {
            return descriptionLabelText;
        }
        public void FitPicToComp()
        {
            PictureBox.Image = ComponentType.image;
        }
        public int GetUsize()
        {
            return this.ComponentType.USize;
        }
        public void UpdateDescription(string text)
        {
            string sql = "Update Components Set ComponentDescription='" + text + "' Where ComponentID=" + this.ComponentID;
            Globs.DB.Update(sql);
            this.descriptionLabelText = text;
        }
        #region Component Presentation On RackView
        #endregion
    }
}
