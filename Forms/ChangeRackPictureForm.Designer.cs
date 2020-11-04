namespace RackKeyV07
{
    partial class ChangeRackPictureForm
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
            this.labelPic = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxCurrent = new System.Windows.Forms.PictureBox();
            this.textBoxPicFilePath = new MetroFramework.Controls.MetroTextBox();
            this.btnChoose = new MetroFramework.Controls.MetroButton();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.labelCurrentPic = new MetroFramework.Controls.MetroLabel();
            this.labelNewPIC = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPic
            // 
            this.labelPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPic.AutoSize = true;
            this.labelPic.Location = new System.Drawing.Point(23, 62);
            this.labelPic.Name = "labelPic";
            this.labelPic.Size = new System.Drawing.Size(86, 19);
            this.labelPic.TabIndex = 0;
            this.labelPic.Text = "מיקום תמונה:";
            this.labelPic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxCurrent
            // 
            this.pictureBoxCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCurrent.Location = new System.Drawing.Point(23, 120);
            this.pictureBoxCurrent.Name = "pictureBoxCurrent";
            this.pictureBoxCurrent.Size = new System.Drawing.Size(143, 223);
            this.pictureBoxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCurrent.TabIndex = 1;
            this.pictureBoxCurrent.TabStop = false;
            // 
            // textBoxPicFilePath
            // 
            this.textBoxPicFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxPicFilePath.CustomButton.Image = null;
            this.textBoxPicFilePath.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.textBoxPicFilePath.CustomButton.Name = "";
            this.textBoxPicFilePath.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.textBoxPicFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPicFilePath.CustomButton.TabIndex = 1;
            this.textBoxPicFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPicFilePath.CustomButton.UseSelectable = true;
            this.textBoxPicFilePath.CustomButton.Visible = false;
            this.textBoxPicFilePath.Lines = new string[] {
        "מיקום תמונה"};
            this.textBoxPicFilePath.Location = new System.Drawing.Point(115, 60);
            this.textBoxPicFilePath.MaxLength = 32767;
            this.textBoxPicFilePath.Name = "textBoxPicFilePath";
            this.textBoxPicFilePath.PasswordChar = '\0';
            this.textBoxPicFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPicFilePath.SelectedText = "";
            this.textBoxPicFilePath.SelectionLength = 0;
            this.textBoxPicFilePath.SelectionStart = 0;
            this.textBoxPicFilePath.ShortcutsEnabled = true;
            this.textBoxPicFilePath.Size = new System.Drawing.Size(274, 21);
            this.textBoxPicFilePath.TabIndex = 2;
            this.textBoxPicFilePath.Text = "מיקום תמונה";
            this.textBoxPicFilePath.UseSelectable = true;
            this.textBoxPicFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPicFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.Location = new System.Drawing.Point(395, 60);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(61, 21);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "בחר";
            this.btnChoose.UseSelectable = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openPictureDialog";
            this.openPictureDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openPictureDialog_FileOk);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(201, 349);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 26);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "שנה";
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelCurrentPic
            // 
            this.labelCurrentPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentPic.AutoSize = true;
            this.labelCurrentPic.Location = new System.Drawing.Point(47, 98);
            this.labelCurrentPic.Name = "labelCurrentPic";
            this.labelCurrentPic.Size = new System.Drawing.Size(89, 19);
            this.labelCurrentPic.TabIndex = 5;
            this.labelCurrentPic.Text = "תמונה נוכחית";
            // 
            // labelNewPIC
            // 
            this.labelNewPIC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNewPIC.AutoSize = true;
            this.labelNewPIC.Location = new System.Drawing.Point(347, 98);
            this.labelNewPIC.Name = "labelNewPIC";
            this.labelNewPIC.Size = new System.Drawing.Size(85, 19);
            this.labelNewPIC.TabIndex = 6;
            this.labelNewPIC.Text = "תמונה חדשה";
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNew.Location = new System.Drawing.Point(313, 120);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(143, 223);
            this.pictureBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNew.TabIndex = 7;
            this.pictureBoxNew.TabStop = false;
            this.pictureBoxNew.Click += new System.EventHandler(this.pictureBoxNew_Click);
            // 
            // ChangeRackPictureForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 398);
            this.Controls.Add(this.pictureBoxNew);
            this.Controls.Add(this.labelNewPIC);
            this.Controls.Add(this.labelCurrentPic);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.textBoxPicFilePath);
            this.Controls.Add(this.pictureBoxCurrent);
            this.Controls.Add(this.labelPic);
            this.Name = "ChangeRackPictureForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "שנה תמונת ארון";
            this.Load += new System.EventHandler(this.ChangeRackPictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelPic;
        private System.Windows.Forms.PictureBox pictureBoxCurrent;
        private MetroFramework.Controls.MetroTextBox textBoxPicFilePath;
        private MetroFramework.Controls.MetroButton btnChoose;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroLabel labelCurrentPic;
        private MetroFramework.Controls.MetroLabel labelNewPIC;
        private System.Windows.Forms.PictureBox pictureBoxNew;
    }
}