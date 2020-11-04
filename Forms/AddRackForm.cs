using MetroFramework.Forms;
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

namespace RackKeyV07
{
    public partial class AddRackForm : MetroFramework.Forms.MetroForm
    {
        private Point create;
        public AddRackForm(Point p)
        {
            create = p;
            InitializeComponent();
        }

        private void AddRackForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 45; i++)
            {
                comboBoxSize.Items.Add(i);
            }
        }
        private void openPictureDialog_FileOk(object sender, CancelEventArgs e)
        {
            string path = openPictureDialog.FileName;
            if (!string.IsNullOrEmpty(path))
            {
                textBoxPicture.Text = openPictureDialog.FileName;
                pictureBoxRack.Image = Project.GetCorrectedImage(pictureBoxRack.ImageLocation);
                CorrectExifOrientation(pictureBoxRack.Image);
                Refresh();
            } 
        }
        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            openPictureDialog.Filter = "Bitmaps|*.bmp|PNG files|*.png|JPEG files|*.jpg|GIF files|*.gif|TIFF files|*.tif|Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            openPictureDialog.ShowDialog();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {            
            if (textBoxName.Text!=null)
            {
                if (comboBoxSize.SelectedItem!=null)
                {
                    bool passedVerification = true;
                    foreach (Rack rk in Main.NetworkRacks)
                    {
                        if (rk.name == textBoxName.Text)
                        {
                            passedVerification = false;
                            MessageBox.Show("השם הזה כבר תפוס,אנא תבחר שם אחר לארון או שתמחק את הארון הקיים");
                        }
                    }
                    if (passedVerification)
                    {
                        string imagePath = "";
                        if (pictureBoxRack.ImageLocation != null)
                        {
                            imagePath = Globs.CurrentProject.CopyImageGetPath(pictureBoxRack.ImageLocation,"Rack"+Main.AvailableRackID()+Path.GetExtension(pictureBoxRack.ImageLocation)); 
                        }

                        Rack newrack = new Rack(int.Parse(comboBoxSize.SelectedItem.ToString()), textBoxName.Text,imagePath, create);

                        Main.AddNewRack(newrack);
                        newrack.control = Globs.activeMainForm.CreateBtn(newrack);
                        Globs.activeMainForm.Refresh();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("לא הוגדר גודל לארון");
                }
            }
            else
            {
                MessageBox.Show("לא נבחר שם לארון");
            }
        }

        private void CorrectExifOrientation(Image image)
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


    }
}
