using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackKeyV07.Forms
{
    public partial class AddAreaForm : MetroFramework.Forms.MetroForm
    {
        private Point PanelLocation;
        public AddAreaForm(Point point)
        {            
            this.PanelLocation = point;
            InitializeComponent();
        }

        private void AddAreaForm_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            openPictureDialog.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif";
            openPictureDialog.ShowDialog();
        }

        private void openPictureDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (openPictureDialog.FileName!=null)
            {
                if (openPictureDialog.FileName!=string.Empty)
                {
                    if (File.Exists(openPictureDialog.FileName))
                    {
                        textBoxPicLocation.Text = openPictureDialog.FileName;
                        pictureBoxShow.Image = Project.GetCorrectedImage(openPictureDialog.FileName);
                        ImageExtensions.NormalizeOrientation(pictureBoxShow.Image);
                        pictureBoxShow.Refresh();
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (File.Exists(textBoxPicLocation.Text))
            {
                Panel IntrestPanel = new Panel();
                IntrestPanel.Location = this.PanelLocation;
                IntrestPanel.Size = new Size(50, 50);
                string imagepath = Globs.CurrentProject.CopyImageGetPath(textBoxPicLocation.Text,"Area"+Main.AvailableAreaID().ToString()+Path.GetExtension(textBoxPicLocation.Text));
                AreaPicture area = new AreaPicture(IntrestPanel,imagepath);
                
                Main.AddAreas(area);
                Globs.activeMainForm.DefineArea(area);
                area.SetVisibleTrue(null);
                this.Close();
            }
            else
            {
                MessageBox.Show("לא נמצאה תמונה");
            }
        }
    }
}
