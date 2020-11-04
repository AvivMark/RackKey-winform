namespace RackKeyV07.Forms
{
    partial class AddAreaForm
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
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.textBoxPicLocation = new MetroFramework.Controls.MetroTextBox();
            this.labelChoose = new MetroFramework.Controls.MetroLabel();
            this.btnChoose = new MetroFramework.Controls.MetroButton();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(226, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(121, 39);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "הוסף";
            this.btnOk.UseSelectable = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBoxShow);
            this.metroPanel1.Controls.Add(this.btnChoose);
            this.metroPanel1.Controls.Add(this.labelChoose);
            this.metroPanel1.Controls.Add(this.textBoxPicLocation);
            this.metroPanel1.Controls.Add(this.btnOk);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(574, 298);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // textBoxPicLocation
            // 
            // 
            // 
            // 
            this.textBoxPicLocation.CustomButton.Image = null;
            this.textBoxPicLocation.CustomButton.Location = new System.Drawing.Point(393, 1);
            this.textBoxPicLocation.CustomButton.Name = "";
            this.textBoxPicLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPicLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPicLocation.CustomButton.TabIndex = 1;
            this.textBoxPicLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPicLocation.CustomButton.UseSelectable = true;
            this.textBoxPicLocation.CustomButton.Visible = false;
            this.textBoxPicLocation.Lines = new string[0];
            this.textBoxPicLocation.Location = new System.Drawing.Point(67, 20);
            this.textBoxPicLocation.MaxLength = 32767;
            this.textBoxPicLocation.Name = "textBoxPicLocation";
            this.textBoxPicLocation.PasswordChar = '\0';
            this.textBoxPicLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPicLocation.SelectedText = "";
            this.textBoxPicLocation.SelectionLength = 0;
            this.textBoxPicLocation.SelectionStart = 0;
            this.textBoxPicLocation.ShortcutsEnabled = true;
            this.textBoxPicLocation.Size = new System.Drawing.Size(415, 23);
            this.textBoxPicLocation.TabIndex = 2;
            this.textBoxPicLocation.UseSelectable = true;
            this.textBoxPicLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPicLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Location = new System.Drawing.Point(488, 20);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(83, 19);
            this.labelChoose.TabIndex = 3;
            this.labelChoose.Text = "מיקום תמונה";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(3, 20);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(58, 23);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "בחר";
            this.btnChoose.UseSelectable = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Location = new System.Drawing.Point(67, 67);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(461, 183);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 5;
            this.pictureBoxShow.TabStop = false;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openPictureDialog_FileOk);
            // 
            // AddAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 385);
            this.Controls.Add(this.metroPanel1);
            this.Name = "AddAreaForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הוסף תצלום אזורי";
            this.Load += new System.EventHandler(this.AddAreaForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnChoose;
        private MetroFramework.Controls.MetroLabel labelChoose;
        private MetroFramework.Controls.MetroTextBox textBoxPicLocation;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
    }
}