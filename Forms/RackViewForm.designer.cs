namespace RackKeyV07
{
    partial class RackViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RackViewForm));
            this.ctxComponent = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.מחקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.שנהתיאורToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new RackKeyV07.DoubleBufferedPanel();
            this.panelLabel = new RackKeyV07.DoubleBufferedPanel();
            this.labelDescription = new MetroFramework.Controls.MetroLabel();
            this.panelRackContainer = new RackKeyV07.DoubleBufferedPanel();
            this.panelRack = new RackKeyV07.DoubleBufferedPanel();
            this.panelStrips = new RackKeyV07.DoubleBufferedPanel();
            this.BottomBorderPB = new System.Windows.Forms.PictureBox();
            this.TopBorderPB = new System.Windows.Forms.PictureBox();
            this.ctxComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelLabel.SuspendLayout();
            this.panelRackContainer.SuspendLayout();
            this.panelRack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomBorderPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBorderPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxComponent
            // 
            this.ctxComponent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.מחקToolStripMenuItem,
            this.שנהתיאורToolStripMenuItem});
            this.ctxComponent.Name = "metroContextMenu1";
            this.ctxComponent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctxComponent.Size = new System.Drawing.Size(130, 48);
            // 
            // מחקToolStripMenuItem
            // 
            this.מחקToolStripMenuItem.Name = "מחקToolStripMenuItem";
            this.מחקToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.מחקToolStripMenuItem.Text = "מחק";
            this.מחקToolStripMenuItem.Click += new System.EventHandler(this.מחקToolStripMenuItem_Click);
            // 
            // שנהתיאורToolStripMenuItem
            // 
            this.שנהתיאורToolStripMenuItem.Name = "שנהתיאורToolStripMenuItem";
            this.שנהתיאורToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.שנהתיאורToolStripMenuItem.Text = "שנה תיאור";
            this.שנהתיאורToolStripMenuItem.Click += new System.EventHandler(this.שנהתיאורToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::RackKeyV07.Properties.Resources.Habasor;
            this.pictureBox2.Location = new System.Drawing.Point(920, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RackKeyV07.Properties.Resources.WhatsApp_Image_2020_07_23_at_08_57_51;
            this.pictureBox1.Location = new System.Drawing.Point(58, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelLabel);
            this.panelMain.Controls.Add(this.panelRackContainer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.HorizontalScrollbar = true;
            this.panelMain.HorizontalScrollbarBarColor = false;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 8;
            this.panelMain.Location = new System.Drawing.Point(20, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1042, 954);
            this.panelMain.TabIndex = 5;
            this.panelMain.VerticalScrollbar = true;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 10;
            // 
            // panelLabel
            // 
            this.panelLabel.Controls.Add(this.labelDescription);
            this.panelLabel.HorizontalScrollbarBarColor = true;
            this.panelLabel.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLabel.HorizontalScrollbarSize = 10;
            this.panelLabel.Location = new System.Drawing.Point(656, 177);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(334, 384);
            this.panelLabel.TabIndex = 6;
            this.panelLabel.VerticalScrollbarBarColor = true;
            this.panelLabel.VerticalScrollbarHighlightOnWheel = false;
            this.panelLabel.VerticalScrollbarSize = 10;
            // 
            // labelDescription
            // 
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescription.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelDescription.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelDescription.Location = new System.Drawing.Point(0, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(334, 384);
            this.labelDescription.Style = MetroFramework.MetroColorStyle.Black;
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "תיאור";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRackContainer
            // 
            this.panelRackContainer.AutoScroll = true;
            this.panelRackContainer.Controls.Add(this.panelRack);
            this.panelRackContainer.HorizontalScrollbar = true;
            this.panelRackContainer.HorizontalScrollbarBarColor = true;
            this.panelRackContainer.HorizontalScrollbarHighlightOnWheel = true;
            this.panelRackContainer.HorizontalScrollbarSize = 10;
            this.panelRackContainer.Location = new System.Drawing.Point(12, 3);
            this.panelRackContainer.Name = "panelRackContainer";
            this.panelRackContainer.Size = new System.Drawing.Size(574, 932);
            this.panelRackContainer.TabIndex = 5;
            this.panelRackContainer.VerticalScrollbar = true;
            this.panelRackContainer.VerticalScrollbarBarColor = true;
            this.panelRackContainer.VerticalScrollbarHighlightOnWheel = false;
            this.panelRackContainer.VerticalScrollbarSize = 10;
            // 
            // panelRack
            // 
            this.panelRack.Controls.Add(this.panelStrips);
            this.panelRack.Controls.Add(this.BottomBorderPB);
            this.panelRack.Controls.Add(this.TopBorderPB);
            this.panelRack.HorizontalScrollbarBarColor = true;
            this.panelRack.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRack.HorizontalScrollbarSize = 10;
            this.panelRack.Location = new System.Drawing.Point(3, 3);
            this.panelRack.Name = "panelRack";
            this.panelRack.Size = new System.Drawing.Size(550, 117);
            this.panelRack.TabIndex = 4;
            this.panelRack.VerticalScrollbarBarColor = true;
            this.panelRack.VerticalScrollbarHighlightOnWheel = false;
            this.panelRack.VerticalScrollbarSize = 10;
            // 
            // panelStrips
            // 
            this.panelStrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStrips.HorizontalScrollbarBarColor = true;
            this.panelStrips.HorizontalScrollbarHighlightOnWheel = false;
            this.panelStrips.HorizontalScrollbarSize = 10;
            this.panelStrips.Location = new System.Drawing.Point(0, 62);
            this.panelStrips.Name = "panelStrips";
            this.panelStrips.Size = new System.Drawing.Size(550, 0);
            this.panelStrips.TabIndex = 5;
            this.panelStrips.VerticalScrollbarBarColor = true;
            this.panelStrips.VerticalScrollbarHighlightOnWheel = false;
            this.panelStrips.VerticalScrollbarSize = 10;
            // 
            // BottomBorderPB
            // 
            this.BottomBorderPB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorderPB.Image = global::RackKeyV07.Properties.Resources.Bottom_rack_border;
            this.BottomBorderPB.Location = new System.Drawing.Point(0, 62);
            this.BottomBorderPB.Name = "BottomBorderPB";
            this.BottomBorderPB.Size = new System.Drawing.Size(550, 55);
            this.BottomBorderPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomBorderPB.TabIndex = 4;
            this.BottomBorderPB.TabStop = false;
            // 
            // TopBorderPB
            // 
            this.TopBorderPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPB.Image = global::RackKeyV07.Properties.Resources.top_rack_border;
            this.TopBorderPB.Location = new System.Drawing.Point(0, 0);
            this.TopBorderPB.Name = "TopBorderPB";
            this.TopBorderPB.Size = new System.Drawing.Size(550, 62);
            this.TopBorderPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopBorderPB.TabIndex = 2;
            this.TopBorderPB.TabStop = false;
            // 
            // RackViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1082, 1034);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 1440);
            this.Name = "RackViewForm";
            this.Text = "Rack View";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RackViewForm_FormClosing);
            this.Load += new System.EventHandler(this.RackViewForm_Load);
            this.ctxComponent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelLabel.ResumeLayout(false);
            this.panelRackContainer.ResumeLayout(false);
            this.panelRack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BottomBorderPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBorderPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox TopBorderPB;
        private System.Windows.Forms.PictureBox BottomBorderPB;
        private DoubleBufferedPanel panelRack;
        private DoubleBufferedPanel panelStrips;
        private DoubleBufferedPanel panelMain;
        private DoubleBufferedPanel panelLabel;
        private MetroFramework.Controls.MetroLabel labelDescription;
        private DoubleBufferedPanel panelRackContainer;
        private MetroFramework.Controls.MetroContextMenu ctxComponent;
        private System.Windows.Forms.ToolStripMenuItem מחקToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem שנהתיאורToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}