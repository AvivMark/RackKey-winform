using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackKeyV07
{
    public partial class AddComponent : MetroFramework.Forms.MetroForm
    {
        public int Rackindex;
        List<Form> childforms = new List<Form>();
        public AddComponent(int i)
        {
            InitializeComponent();
            foreach (ComponentType item in Main.componentTypes)
            {
                comboBoxImages.Items.Add(item);
            }
            Rackindex = i;
        }

        private void AddComponent_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxImages_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComponentType selected = comboBoxImages.SelectedItem as ComponentType;
            pictureBoxComponent.Image = selected.image;
            Refresh();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (comboBoxImages.SelectedItem!=null)
            {
                ComponentType selected = comboBoxImages.SelectedItem as ComponentType;

                Component newcomponent = new Component(selected, Rackindex, textBoxDescription.Text,0);

                if ((newcomponent.GetUsize() + newcomponent.rackIndex) > Globs.rackClicked.components.Length)
                {
                    MessageBox.Show("הרכיב גדול מידי בשביל להיות במיקום הנבחר");
                    return;
                }
                else
                {
                    for (int i = newcomponent.rackIndex + 1; i < (newcomponent.GetUsize() + newcomponent.rackIndex); i++)
                    {
                        if (Globs.rackClicked.components[i] != null)
                        {
                            MessageBox.Show("ישנם רכיבים המפריעים לרכיב זה");
                            return;
                        }

                    }
                }
                Globs.rackClicked.AddComponent(newcomponent);
                this.Close();
            }
        }

        private void ComponentPB_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void AddTypeBtn_Click(object sender, EventArgs e)
        {

            AddComponentTypeForm frm = new AddComponentTypeForm();
            frm.FormClosed += Frm_FormClosed;
            childforms.Add(frm);
            frm.Show(); 
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {

            foreach (ComponentType item in Main.componentTypes)
            {
                if (comboBoxImages.Items.Contains(item) ==  false)
                {
                    comboBoxImages.Items.Add(item);
                }
            }
            comboBoxImages.Refresh();
        }

        private void CloseAllChildFORMS()
        {
            foreach (var item in childforms)
            {
                item.Close();
            }
        }

        private void AddComponent_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllChildFORMS();
        }
    }
}
