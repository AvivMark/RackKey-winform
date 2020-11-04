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
    public class AreaPicture
    {
        public Panel panelArea;
        public Image panelHoverImage;
        public string ImageLocation;
        public int ID;
        public static int sum = 0;
        public AreaPicture(Panel panel, Image image,string imgPath)
        {
            this.panelArea = panel; 
            this.panelHoverImage = Project.GetCorrectedImage(imgPath);
            ImageExtensions.NormalizeOrientation(panelHoverImage);
            this.ImageLocation = imgPath;
            sum++;
            ID = sum;

        }
        public AreaPicture(Panel panel, string imgPath)
        {

            this.ImageLocation = imgPath;
            this.panelHoverImage = Project.GetCorrectedImage(imgPath);
            ImageExtensions.NormalizeOrientation(panelHoverImage);
            this.panelArea = panel;
            sum++;
            ID = sum;
        }
        public void SetVisibleTrue(ContextMenuStrip ctx)
        {            
            ControlMoverOrResizer.Init(this.panelArea);
            panelArea.Visible = true;
            panelArea.BorderStyle = BorderStyle.FixedSingle;
            SetCtxMenu(ctx);
            panelArea.SendToBack();

        }
        public void SetInvisible()
        {
            panelArea.SendToBack();
            panelArea.BorderStyle = BorderStyle.None;

            SetCtxMenu(null);
            panelArea.BorderStyle = BorderStyle.None;
            panelArea.MouseDown += null;

        }


        public void SetCtxMenu(ContextMenuStrip ctx)
        {
            this.panelArea.ContextMenuStrip = ctx;
        }
        public void DeleteImage()
        {
            if (File.Exists(this.ImageLocation))
            {
                File.Delete(this.ImageLocation);
            }
        }
    }
}
