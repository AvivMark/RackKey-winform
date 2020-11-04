using System;
using System.Windows.Forms;
using System.Drawing;
namespace RackKeyv0_
{
    public partial class MainRoomView : MetroFramework.Forms.MetroForm
    {
        public MainRoomView()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetRoomSize();
        }
        private void SetRoomSize()
        {
            int height = Properties.Settings.Default.RoomLength * 100;
            int Width = Properties.Settings.Default.RoomWidth * 100;
            panelRacks.Size = new System.Drawing.Size(Width,height);
            panelMain.Size = new System.Drawing.Size(panelRacks.Width + panelRackPicture.Width, panelRacks.Height);
            this.Height = panelMain.Height;
            this.Width = panelMain.Width;
        }
        private void linkSetting_Click(object sender, EventArgs e)
        {
            if (ctxSettingMenu.Visible!= true)
            {
                ctxSettingMenu.Show(linkSetting, 0, linkSetting.Height);
            }
            else
            {
                ctxSettingMenu.Close();
            }
        }

        private void linkEdit_Click(object sender, EventArgs e)
        {
            if (ctxSettingMenu.Visible != true)
            {
                ctxEditMenu.Show(linkEdit, 0, linkEdit.Height);
            }
            else
            {
                ctxEditMenu.Close();
            }
        }

        private void הוסףארוןToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void הגדרותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm SetFrm = new SettingsForm();
            SetFrm.Show();
        }
        Point panelmouseDownLocation;

        private void הוספתאזורענייןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel IntrestPanel = new Panel();
            IntrestPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            IntrestPanel.Location = panelRacks.Location;
            IntrestPanel.Size = new Size(50, 50);
            IntrestPanel.MouseHover += IntrestPanel_MouseHover;
            IntrestPanel.MouseLeave += IntrestPanel_MouseLeave;
            ControlManager.ControlMoverOrResizer.Init(IntrestPanel);
            panelRacks.Controls.Add(IntrestPanel);
        }

        private void IntrestPanel_MouseLeave(object sender, EventArgs e)
        {
            metroLink1.BackgroundImage = null;
            Refresh();
        }

        private void IntrestPanel_MouseHover(object sender, EventArgs e)
        {
            metroLink1.BackgroundImage = Properties.Resources.cabinets;
            Refresh();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            metroLink1.BackgroundImage = Properties.Resources.cabinets;
            Refresh();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            metroLink1.BackgroundImage = null;
            Refresh();
        }
    }
}
