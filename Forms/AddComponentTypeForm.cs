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
    public partial class AddComponentTypeForm : MetroFramework.Forms.MetroForm
    {
        public AddComponentTypeForm()
        {
            InitializeComponent();
        }

        private void AddComponentTypeForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 45; i++)
            {
                comboBoxSize.Items.Add(i);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (textBoxName.Text!= string.Empty)
            {
                bool InList = false;
                foreach (ComponentType item in Main.componentTypes)
                {
                    if (item.TypeName == textBoxPicPath.Text)
                    {
                        InList = true;
                    }
                }
                if (!InList)
                {


                    if (comboBoxSize.SelectedItem != null)
                    {
                        if (openFileDialog1.FileName != string.Empty && File.Exists(textBoxPicPath.Text))
                        {
                            string OriginalPath = openFileDialog1.FileName;
                            string imagepath = Globs.CurrentProject.CopyImageGetPath(OriginalPath,"Type" + Main.GetAvailableComponentTypeID()+ Path.GetExtension(OriginalPath));

                            ComponentType newType = new ComponentType(textBoxName.Text, imagepath, (int)(comboBoxSize.SelectedItem));
                            newType.ID = Main.GetAvailableComponentTypeID();
                            Main.AddComponentType(newType);
                            if (AddComponent.ActiveForm!=null)
                            {
                                AddComponent.ActiveForm.Close();
                            }
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("תמונה שנבחרה לא תקינה או שהמיקום שלה לא תקין");
                        }
                    }
                    else
                    {
                        MessageBox.Show("חייב לבחור גודל");
                    }
                }
                else
                {
                    MessageBox.Show("סוג רכיב זה כבר קיים");
                }
            }
            else
            {
                MessageBox.Show("שם לא תקין");
            }
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBoxPicPath.Text = openFileDialog1.FileName;
            picBoxComponent.ImageLocation = openFileDialog1.FileName;
            picBoxComponent.Refresh();
        }
    }
}
