using RackKeyV07.Forms;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
namespace RackKeyV07
{
    public partial class RackViewForm : MetroFramework.Forms.MetroForm
    {
        public FixedPictureBox[] componentsPictures = new FixedPictureBox[Globs.rackClicked.u_size];
        public List<Form> ChildForms = new List<Form>();
        public RackViewForm()
        {
            InitializeComponent();
            this.Text = Globs.rackClicked.name;
            componentsPictures =  new FixedPictureBox[ Globs.rackClicked.u_size];
            
        }

        private void RackViewForm_Load(object sender, EventArgs e)
        {
            panelStrips.Height = 0;
            CreateStrips();
            panelRack.Height = panelRack.Height + Globs.stripSize.Height * Globs.rackClicked.u_size - 1;
            LoadComponentsToForm();
        }
        #region Dynamic CONTROLS functions
        private void CreateStrips()
        {
            
            for (int i = componentsPictures.Length-1; i >= 0; i--)
            {
                PictureBox strip = new PictureBox();
                strip.Image = Properties.Resources.strip_1u;
                strip.SizeMode = PictureBoxSizeMode.StretchImage;
                strip.Dock = DockStyle.Top;
                componentsPictures[i] = CreateStripButton(strip);
                panelStrips.Controls.Add(strip);
            }

        }
        private FixedPictureBox CreateStripButton(PictureBox strip)
        {
            FixedPictureBox addbutton = new FixedPictureBox();
            addbutton.MouseHover += Addbutton_MouseHover;
            addbutton.MouseLeave += Addbutton_MouseLeave;
            addbutton.MouseClick += Addbutton_MouseClick;
            addbutton.Cursor = Cursors.Hand;
            addbutton.Size = new Size(Globs.stripSize.Height, Globs.stripSize.Height);
            addbutton.Image = Properties.Resources.Addbutton;
            addbutton.SizeMode = PictureBoxSizeMode.StretchImage;
            addbutton.Location = new Point(strip.Location.X + Globs.stripSize.Width/2-25, strip.Location.Y);
            strip.Controls.Add(addbutton);
            return addbutton;
        }
       

        #region Add Button Events
        private void Addbutton_MouseLeave(object sender, EventArgs e)
        {

            PictureBox button = sender as PictureBox;
            button.Image = Properties.Resources.Addbutton;
        }
        private void Addbutton_MouseHover(object sender, EventArgs e)
        {
            
            PictureBox button = sender as PictureBox;
            button.Image = Properties.Resources.AddComponentHover;
        }
        private void Addbutton_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox addbutton = sender as PictureBox;
            for (int i = 0; i < componentsPictures.Length; i++)
            {
                if (componentsPictures[i] == addbutton)
                {
                    AddComponent addform = new AddComponent(i);
                    ChildForms.Add(addform);
                    addform.FormClosed += Addform_FormClosed;
                    addform.Show();
                    return;
                }
            }
        }

        private void Addform_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddComponent form = (sender as AddComponent);
            Component componentAdded = Globs.rackClicked.components[form.Rackindex];
            if (Globs.rackClicked.components[form.Rackindex] != null)
            {

                DefineComponentPictureBox(componentsPictures[form.Rackindex], componentAdded);
                componentsPictures[form.Rackindex].Refresh();
            }
        }
        #endregion

        #endregion
        #region LoadComponents
        public void LoadComponentsToForm()
        {
            for (int i = 0; i < componentsPictures.Length; i++)
            {
                Component comp = Globs.rackClicked.components[i];
                if (comp != null)
                {
                    DefineComponentPictureBox(componentsPictures[i], comp);
                }
            }
        }
        public void DefineComponentPictureBox(PictureBox AddButton,Component component)
        {
            PictureBox ComponentPB = new PictureBox();
            ComponentPB.SizeMode = PictureBoxSizeMode.StretchImage;
            ComponentPB.Location = new Point(62, AddButton.Parent.Location.Y);//62 - picture box left location
            ComponentPB.Size = new Size(425, component.ComponentType.USize * 50);//425 - picture Box Width
            ComponentPB.ContextMenuStrip = ctxComponent;
            ComponentPB.MouseHover += ComponentPB_MouseHover;
            ComponentPB.MouseLeave += ComponentPB_MouseLeave;
            component.SetPicBox(ComponentPB);
            component.FitPicToComp();
            panelStrips.Controls.Add(ComponentPB);
            ComponentPB.BringToFront();
            panelStrips.Refresh();
        }
        private void ComponentPB_MouseLeave(object sender, EventArgs e)
        {
            labelDescription.Text = string.Empty;
            labelDescription.Refresh();
        }
        private void ComponentPB_MouseHover(object sender, EventArgs e)
        {
            for (int i = 0; i < componentsPictures.Length; i++)
            {
                Component comp = Globs.rackClicked.components[i];
                if (comp != null)
                {
                    if (comp.PictureBox == (sender as PictureBox))
                    {
                        labelDescription.Text = comp.descriptionLabelText;
                        labelDescription.Refresh();
                        return;
                    }
                }
            }
        }
        #endregion

        #region Component Context Menu
        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox clicked = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as PictureBox;
            Component toRemove = Globs.rackClicked.FindComponent(clicked);
            Globs.rackClicked.RemoveComponent(toRemove);
            panelStrips.Controls.Remove(clicked);
            clicked.Refresh();
        }
        private void שנהתיאורToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox clicked = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as PictureBox;
            Component changeDesc = Globs.rackClicked.FindComponent(clicked);
            ChangeComponentDescriptionForm frm = new ChangeComponentDescriptionForm(changeDesc);
            ChildForms.Add(frm);
            frm.Show();
        }
        #endregion

        private void RackViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllChildFORMS();
            foreach (var item in componentsPictures)
            {
                item.Image.Dispose();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void CloseAllChildFORMS()
        {
            foreach (var item in ChildForms)
            {
                item.Close();
            }
        }
    }
}
