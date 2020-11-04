using RackKeyV07.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using RackKeyV07.Classes;

namespace RackKeyV07
{
    public partial class MainRoomView : MetroFramework.Forms.MetroForm
    {
        public MainRoomView()
        {
            if (Globs.CurrentProject == null)
            {
                this.Hide();
                ProjectStartForm SelectProjectfrm = new ProjectStartForm();
                SelectProjectfrm.Show();
            }
            else
            {
                Thread t = new Thread(new ThreadStart(delegate
                {
                    StartSplashScreen();
                }));
                t.Start();
                Thread.Sleep(5000);
                InitializeComponent();
                Show();
                Focus();
                try
                {
                    t.Abort();
                }
                catch
                { }
            }
        }
        private void StartSplashScreen()
        {
            try
            {
                frmSplashScreen splashScreen = new frmSplashScreen();
                Application.Run(splashScreen);
            }
            catch(Exception ex)
            {
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if (Globs.CurrentProject != null)
            {
                Main.LoadTypes();
                Globs.main.LoadRacks();
                CreateAllBtns();
                LoadDecorationsToForm();
                LoadAreas();
                this.Text = Properties.Settings.Default.ProjectName;
            }
        }

        #region Add Rack Button Events
        public void CreateAllBtns()
        {
            foreach (Rack rack in Main.NetworkRacks)
            {
                rack.control = CreateBtn(rack);
            }
        }
        public  Control CreateBtn(Rack rack)
        {
            LinkLabel b = new LinkLabel();
            b.ContextMenuStrip = ctxRackMenu;
            b.Location = rack.Location;
            b.Font = Globs.RackMainFont;
            if (rack.control.Size == null)
            {
                b.Size = Globs.RackButtonSize;
            }
            else
            {
                b.Size = rack.control.Size;
            }
            b.AutoSize = false;
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.LinkColor = Color.Black;
            b.ActiveLinkColor = Color.Black;
            b.Text = rack.name;
            b.Cursor = Cursors.Hand;
            b.BackgroundImage = Properties.Resources.ServerRack;
            b.BackgroundImageLayout = ImageLayout.Stretch;
            b.LinkBehavior = LinkBehavior.HoverUnderline;
            AddBtnEvents(b, rack);
            ControlMoverOrResizer.Init(b);
            panelRacks.Controls.Add(b);
            b.BringToFront();
            return b;
        }
        private void AddBtnEvents(LinkLabel btn,Rack rk)
        {
            btn.MouseEnter += Btn_MouseEnter; 
            btn.MouseLeave += Btn_MouseLeave;
            btn.MouseDoubleClick += Btn_MouseDoubleClick;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            LinkLabel b = sender as LinkLabel;
            b.LinkColor = Color.White;
            b.BackgroundImage = null;
            b.BackColor = Color.Black;
            foreach (Rack rack in Main.NetworkRacks)
            {
                if (rack.name == (sender as LinkLabel).Text)
                {
                    if (rack.rackPicture!= null)
                    {
                        Image img = rack.rackPicture;
                        pictureRack.Image = img;
                        ImageExtensions.NormalizeOrientation(pictureRack.Image);
                        pictureRack.Refresh();

                    }
                }
            }
        }

        private void Btn_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                foreach (Rack rack in Main.NetworkRacks)
                {
                    if (rack.name == (sender as LinkLabel).Text)
                    {
                        Globs.rackClicked = rack;
                    }
                }
                RackViewForm frm = new RackViewForm();
                frm.Text = (sender as LinkLabel).Text;
                frm.Show();
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            LinkLabel b = (sender as LinkLabel);
            b.LinkColor = Color.Black;
            b.BackColor = Color.Transparent;
            b.BackgroundImage = Properties.Resources.ServerRack;
            pictureRack.Image = null;
            Refresh();
        }
        #endregion
        #region Menu Strip Buttons
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
            if (ctxEditMenu.Visible != true)
            {
                ctxEditMenu.Show(linkEdit, 0, linkEdit.Height);
            }
            else
            {
                ctxEditMenu.Close();
            }
        }

        private void linkDevOps_Click(object sender, EventArgs e)
        {
            if (ctxDevOpsMenu.Visible != true)
            {
                ctxDevOpsMenu.Show(linkDevOps, 0, linkDevOps.Height);
            }
            else
            {
                ctxDevOpsMenu.Close();
            }
        }
        #endregion
        #region Context Menu Edit
        private void הצגאזורענייןToolStripMenuItem_Click(object sender, EventArgs e)
        {

            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            if ((sender as ToolStripMenuItem).Checked)
            {
                Globs.main.TurnAllVisible(ctxAreaMenu);
            }
            else
            {
                Globs.main.TurnAlInvisible();
            }
        }
        private void נעוללעריכהToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ערוךסוגירכיביםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditComponentTypesForm frm = new EditComponentTypesForm();
            frm.Show();
        }
        #endregion
        #region Context Menu Settings        
        private void הגדרותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm SetFrm = new SettingsForm();
            SetFrm.Show();
        }

        private void שמורToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globs.main.SaveAll();
        }

        private void חדשToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog NewProjectDialog = new SaveFileDialog();
            string dummyFileName = "RackKey SaveFile";
            NewProjectDialog.Filter = "RackKey(*.rky*)|*.rky*";
            NewProjectDialog.AddExtension = false;
            NewProjectDialog.FileName = dummyFileName;
            NewProjectDialog.CheckFileExists = false;
            if (NewProjectDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = NewProjectDialog.FileName;
                Globs.activeMainForm.Hide();
                Globs.CurrentProject.CloseProject();
                Project newProject = new Project(fileName, false);
                Globs.activeMainForm = new MainRoomView();
                Globs.activeMainForm.Show();

            }
        }

        private void פתחToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openProjectFileDialog = new OpenFileDialog();
            openProjectFileDialog.Filter = "RackKey(*.rky*)|*.rky*";
            if (openProjectFileDialog.ShowDialog() == DialogResult.OK)
            {
                Globs.activeMainForm.Hide();
                Globs.CurrentProject.CloseProject();
                Globs.CurrentProject.OpenProject(openProjectFileDialog.FileName);
                Globs.activeMainForm = new MainRoomView();
                Globs.activeMainForm.Show();
            }
        }

        private void שמורבשםToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion 
        #region Context Menu Clear Area
        private void הוסףארוןToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRackForm frm = new AddRackForm(panelRacks.PointToClient(MousePosition));
            frm.Show();
        }

        private void הוספתאזורענייןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAreaForm form = new AddAreaForm(panelRacks.PointToClient(MousePosition));
            Globs.main.TurnAllVisible(ctxAreaMenu);
            ShowAreas.Checked = true;
            form.Show();
        }
        private void רענןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void ShowAreas_CheckedChanged(object sender, EventArgs e)
        {

        }
        #region Context Menu For Decoration
        private void מחשבToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point p = panelRacks.PointToClient(MousePosition);
            Decoration dec = new Decoration(DecorationType.Computer, p, Globs.defaultDecorationSIZE,0);
            DefineDecoration(dec);
            Main.AddDecoration(dec);
        }
        private void שולחןToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Point p = panelRacks.PointToClient(MousePosition);
            Decoration dec = new Decoration(DecorationType.Table, p, Globs.defaultDecorationSIZE,0);
            DefineDecoration(dec);
            Main.AddDecoration(dec);
        }

        private void טלוויזיהToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Point p = panelRacks.PointToClient(MousePosition);
            Decoration dec = new Decoration(DecorationType.TV, p, Globs.defaultDecorationSIZE,0);
            DefineDecoration(dec);
            Main.AddDecoration(dec);

        }

        private void דלתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point p = panelRacks.PointToClient(MousePosition);

            Decoration dec = new Decoration(DecorationType.Door, p, Globs.defaultDecorationSIZE,0);
            DefineDecoration(dec);
            Main.AddDecoration(dec);

        }

        private void כסאToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point p = panelRacks.PointToClient(MousePosition);

            Decoration dec = new Decoration(DecorationType.Chair, p, Globs.defaultDecorationSIZE,0);
            DefineDecoration(dec);
            Main.AddDecoration(dec);

        }
        #endregion

        #endregion
        #region Context Menu For Rack
        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkLabel b = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as LinkLabel;
            Rack toRemove = null;
            foreach (Rack rack in Main.NetworkRacks)
            {
                if (rack.name == b.Text)
                {
                    toRemove = rack;
                }
            }
            if (toRemove!= null)
            {
                Main.RemoveRack(toRemove);
                panelRacks.Controls.Remove(b);
                Refresh();
            }
        }

        private void שנהתמונהToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LinkLabel b = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as LinkLabel;
            Rack toChange = null;
            foreach (Rack rack in Main.NetworkRacks)
            {
                if (rack.name == b.Text)
                {
                    toChange = rack;
                }
            }

            Globs.rackClicked = toChange;
            ChangeRackPictureForm frm = new ChangeRackPictureForm();
            frm.Show();
        }

        private void שנהשםToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LinkLabel b = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as LinkLabel;
            Rack toChange = null;
            foreach (Rack rack in Main.NetworkRacks)
            {
                if (rack.name == b.Text)
                {
                    toChange = rack;
                }
            }
            Globs.rackClicked = toChange;
            ChangeRackName frm = new ChangeRackName();
            frm.Show();
        }

        #endregion
        #region Context Menu Info
        private void btnInfo_Click(object sender, EventArgs e)
        {

            if (ctxInfoMenu.Visible != true)
            {
                ctxInfoMenu.Show(linkInfo, 0, linkInfo.Height);
            }
            else
            {
                ctxInfoMenu.Close();
            }
        }

        private void אודותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm frm = new InfoForm();
            frm.Show();
        }
        #endregion
        #region Area Load
        public void LoadAreas()
        {
            Main.LoadAreas();
            foreach (AreaPicture item in Main.Areas)
            {
                DefineArea(item);
                item.SetInvisible();
            }
        }
        public void DefineArea(AreaPicture item)
        {
            item.SetCtxMenu(ctxAreaMenu);
            ControlMoverOrResizer.Init(item.panelArea);
            AddAreaEvents(item.panelArea);
            panelRacks.Controls.Add(item.panelArea);
        }
        public void AddAreaEvents(Panel panel)
        {
            panel.MouseMove += Panel_MouseMove;
            panel.MouseLeave += Panel_MouseLeave;
        }


        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            pictureRack.Image = null;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Panel p = sender as Panel;
            AreaPicture area = Globs.main.GetAreaByPanel(p);
            if (area!=null)
            {
                pictureRack.Image = area.panelHoverImage;
                ImageExtensions.NormalizeOrientation(pictureRack.Image);
                pictureRack.Refresh();
            }
        }


        #region Context Menu For Area
        private void מחקToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Panel panel = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as Panel;
            AreaPicture area = Globs.main.GetAreaByPanel(panel);
            Globs.main.RemoveArea(area);
            panelRacks.Controls.Remove(panel);
        }
        #endregion
        #endregion
        #region Decoration Load
        public void LoadDecorationsToForm()
        {
            Main.LoadDecorations();
            foreach (Decoration item in Main.Decorations)
            {
                DefineDecoration(item);
            }
        }
        public void DefineDecoration(Decoration item)
        {
            item.picture.ContextMenuStrip = ctxDecorationMenu;
            item.SetAngle(item.angle);
            item.picture.MouseDoubleClick += Picture_MouseDoubleClick;
            ControlMoverOrResizer.Init(item.picture);
            panelRacks.Controls.Add(item.picture);
        }

        private void Picture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            (sender as PictureBox).BringToFront();
        }
        #endregion

        #region Context Menu Decorations
        private void מחקToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PictureBox pb = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as PictureBox;
            Decoration dec = Main.GetDecorationByPicture(pb);
            if (dec!=null)
            {
                Main.RemoveDecoration(dec);
                panelRacks.Controls.Remove(pb);
            }
        }

        private void סובבשמאלהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pb = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as PictureBox;
            Decoration dec = Main.GetDecorationByPicture(pb);
            dec.RotateLeft();
        }
        private void סובבימינהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pb = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as PictureBox;
            Decoration dec = Main.GetDecorationByPicture(pb);
            dec.RotateRight();
        }
        #endregion
        #region Rotation
        private Bitmap RotateImage(Bitmap b, float Angle)
        {
            // The original bitmap needs to be drawn onto a new bitmap which will probably be bigger 
            // because the corners of the original will move outside the original rectangle.
            // An easy way (OK slightly 'brute force') is to calculate the new bounding box is to calculate the positions of the 
            // corners after rotation and get the difference between the maximum and minimum x and y coordinates.
            float wOver2 = b.Width / 2.0f;
            float hOver2 = b.Height / 2.0f;
            float radians = -(float)(Angle / 180.0 * Math.PI);
            // Get the coordinates of the corners, taking the origin to be the centre of the bitmap.
            PointF[] corners = new PointF[]{
            new PointF(-wOver2, -hOver2),
            new PointF(+wOver2, -hOver2),
            new PointF(+wOver2, +hOver2),
            new PointF(-wOver2, +hOver2)
        };

            for (int i = 0; i < 4; i++)
            {
                PointF p = corners[i];
                PointF newP = new PointF((float)(p.X * Math.Cos(radians) - p.Y * Math.Sin(radians)), (float)(p.X * Math.Sin(radians) + p.Y * Math.Cos(radians)));
                corners[i] = newP;
            }

            // Find the min and max x and y coordinates.
            float minX = corners[0].X;
            float maxX = minX;
            float minY = corners[0].Y;
            float maxY = minY;
            for (int i = 1; i < 4; i++)
            {
                PointF p = corners[i];
                minX = Math.Min(minX, p.X);
                maxX = Math.Max(maxX, p.X);
                minY = Math.Min(minY, p.Y);
                maxY = Math.Max(maxY, p.Y);
            }

            // Get the size of the new bitmap.
            SizeF newSize = new SizeF(maxX - minX, maxY - minY);
            // ...and create it.
            Bitmap returnBitmap = new Bitmap((int)Math.Ceiling(newSize.Width), (int)Math.Ceiling(newSize.Height));
            // Now draw the old bitmap on it.
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                g.TranslateTransform(newSize.Width / 2.0f, newSize.Height / 2.0f);
                g.RotateTransform(Angle);
                g.TranslateTransform(-b.Width / 2.0f, -b.Height / 2.0f);

                g.DrawImage(b, 0, 0);
            }

            return returnBitmap;
        }
        #endregion

        private void MainRoomView_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void MainRoomView_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Globs.CurrentProject.CloseProject();
            Application.Exit();
        }
        #region Context Menu Dev Ops
        private void runDataFixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevOps.CorrectComponentTypes();
        }

        #endregion
    }
}
