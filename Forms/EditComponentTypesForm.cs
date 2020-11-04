using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackKeyV07.Forms
{
    public partial class EditComponentTypesForm : MetroFramework.Forms.MetroForm
    {
        public EditComponentTypesForm()
        {
            InitializeComponent();
        }

        private void EditComponentTypesForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Main.componentTypes)
            {
                listBoxTypes.Items.Add(item);
            }
            for (int i = 1; i < 50; i++)
            {
                comboBoxSize.Items.Add(i);
            }
        }

        private void listBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComponentType selected = listBoxTypes.SelectedItem as ComponentType;
            labelID.Text = selected.ID.ToString();
            textboxName.Text = selected.TypeName;
            comboBoxSize.Text = selected.USize.ToString();
            textboxPicLocation.Text = selected.ImageLocation;
            pictureBoxShowType.Image = selected.image;
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxTypes.SelectedItem!=null)
            {
                ComponentType selected = listBoxTypes.SelectedItem as ComponentType;
                string newName = textboxName.Text;

                string NewImagePATH = textboxPicLocation.Text;
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    selected.TypeName = newName;
                }

                if (comboBoxSize.SelectedItem != null)
                {
                    int newSize = int.Parse(comboBoxSize.SelectedItem.ToString());
                    selected.USize = newSize;
                }

                if (!string.IsNullOrWhiteSpace(NewImagePATH))
                {
                    if (NewImagePATH!= selected.ImageLocation)
                    {
                        selected.SetTypeImage(NewImagePATH);
                    }
                }

                Main.UpdateComponentType(selected);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTypes.SelectedItem != null)
            {
                ComponentType selected = listBoxTypes.SelectedItem as ComponentType;
                Main.RemoveType(selected);
                listBoxTypes.Items.Remove(selected);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddComponentTypeForm frm = new AddComponentTypeForm();
            frm.FormClosed += Frm_FormClosed;
            frm.Show();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var item in Main.componentTypes)
            {
                if (!listBoxTypes.Items.Contains(item))
                {
                    listBoxTypes.Items.Add(item);
                }
            }
        }

        private void choosePicDialog_FileOk(object sender, CancelEventArgs e)
        {
            textboxPicLocation.Text = choosePicDialog.FileName;
        }

        private void textboxPicLocation_TextChanged(object sender, EventArgs e)
        {
            Image img = Project.GetCorrectedImage(textboxPicLocation.Text);
            if (img != null)
            {
                pictureBoxShowType.Image = img;
            }
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            choosePicDialog.Filter = Globs.PictureFilter;
            choosePicDialog.ShowDialog();
        }
    }
}
