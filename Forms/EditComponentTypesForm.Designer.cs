namespace RackKeyV07.Forms
{
    partial class EditComponentTypesForm
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
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.labelIndex = new MetroFramework.Controls.MetroLabel();
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.labelSize = new MetroFramework.Controls.MetroLabel();
            this.textboxName = new MetroFramework.Controls.MetroTextBox();
            this.labelShowImage = new MetroFramework.Controls.MetroLabel();
            this.labelID = new MetroFramework.Controls.MetroLabel();
            this.btnChoosePic = new MetroFramework.Controls.MetroButton();
            this.comboBoxSize = new MetroFramework.Controls.MetroComboBox();
            this.listBoxTypes = new System.Windows.Forms.ListBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.textboxPicLocation = new MetroFramework.Controls.MetroTextBox();
            this.choosePicDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxShowType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(587, 670);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(137, 670);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "מחק";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(770, 63);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(82, 19);
            this.labelIndex.TabIndex = 3;
            this.labelIndex.Text = "אינדקס רכיב";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(789, 110);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 19);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "שם רכיב";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(785, 150);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(64, 19);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "גודל רכיב";
            // 
            // textboxName
            // 
            // 
            // 
            // 
            this.textboxName.CustomButton.Image = null;
            this.textboxName.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.textboxName.CustomButton.Name = "";
            this.textboxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxName.CustomButton.TabIndex = 1;
            this.textboxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxName.CustomButton.UseSelectable = true;
            this.textboxName.CustomButton.Visible = false;
            this.textboxName.Lines = new string[] {
        "שם"};
            this.textboxName.Location = new System.Drawing.Point(514, 110);
            this.textboxName.MaxLength = 32767;
            this.textboxName.Name = "textboxName";
            this.textboxName.PasswordChar = '\0';
            this.textboxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxName.SelectedText = "";
            this.textboxName.SelectionLength = 0;
            this.textboxName.SelectionStart = 0;
            this.textboxName.ShortcutsEnabled = true;
            this.textboxName.Size = new System.Drawing.Size(215, 23);
            this.textboxName.TabIndex = 6;
            this.textboxName.Text = "שם";
            this.textboxName.UseSelectable = true;
            this.textboxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelShowImage
            // 
            this.labelShowImage.AutoSize = true;
            this.labelShowImage.Location = new System.Drawing.Point(774, 401);
            this.labelShowImage.Name = "labelShowImage";
            this.labelShowImage.Size = new System.Drawing.Size(78, 19);
            this.labelShowImage.TabIndex = 9;
            this.labelShowImage.Text = "תמונת רכיב";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(611, 63);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(51, 19);
            this.labelID.TabIndex = 11;
            this.labelID.Text = "אינדקס";
            // 
            // btnChoosePic
            // 
            this.btnChoosePic.Location = new System.Drawing.Point(587, 194);
            this.btnChoosePic.Name = "btnChoosePic";
            this.btnChoosePic.Size = new System.Drawing.Size(75, 23);
            this.btnChoosePic.TabIndex = 12;
            this.btnChoosePic.Text = "שנה תמונה";
            this.btnChoosePic.UseSelectable = true;
            this.btnChoosePic.Click += new System.EventHandler(this.btnChoosePic_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.ItemHeight = 23;
            this.comboBoxSize.Location = new System.Drawing.Point(567, 143);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(121, 29);
            this.comboBoxSize.TabIndex = 13;
            this.comboBoxSize.UseSelectable = true;
            // 
            // listBoxTypes
            // 
            this.listBoxTypes.FormattingEnabled = true;
            this.listBoxTypes.Location = new System.Drawing.Point(23, 102);
            this.listBoxTypes.Name = "listBoxTypes";
            this.listBoxTypes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxTypes.Size = new System.Drawing.Size(370, 550);
            this.listBoxTypes.Sorted = true;
            this.listBoxTypes.TabIndex = 14;
            this.listBoxTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxTypes_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(158, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textboxPicLocation
            // 
            // 
            // 
            // 
            this.textboxPicLocation.CustomButton.Image = null;
            this.textboxPicLocation.CustomButton.Location = new System.Drawing.Point(428, 1);
            this.textboxPicLocation.CustomButton.Name = "";
            this.textboxPicLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxPicLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxPicLocation.CustomButton.TabIndex = 1;
            this.textboxPicLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxPicLocation.CustomButton.UseSelectable = true;
            this.textboxPicLocation.CustomButton.Visible = false;
            this.textboxPicLocation.Lines = new string[] {
        "מיקום תמונה"};
            this.textboxPicLocation.Location = new System.Drawing.Point(399, 234);
            this.textboxPicLocation.MaxLength = 32767;
            this.textboxPicLocation.Name = "textboxPicLocation";
            this.textboxPicLocation.PasswordChar = '\0';
            this.textboxPicLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textboxPicLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxPicLocation.SelectedText = "";
            this.textboxPicLocation.SelectionLength = 0;
            this.textboxPicLocation.SelectionStart = 0;
            this.textboxPicLocation.ShortcutsEnabled = true;
            this.textboxPicLocation.Size = new System.Drawing.Size(450, 23);
            this.textboxPicLocation.TabIndex = 16;
            this.textboxPicLocation.Text = "מיקום תמונה";
            this.textboxPicLocation.UseSelectable = true;
            this.textboxPicLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxPicLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textboxPicLocation.TextChanged += new System.EventHandler(this.textboxPicLocation_TextChanged);
            // 
            // choosePicDialog
            // 
            this.choosePicDialog.FileName = "choosePicDialog";
            this.choosePicDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.choosePicDialog_FileOk);
            // 
            // pictureBoxShowType
            // 
            this.pictureBoxShowType.Location = new System.Drawing.Point(465, 263);
            this.pictureBoxShowType.Name = "pictureBoxShowType";
            this.pictureBoxShowType.Size = new System.Drawing.Size(300, 382);
            this.pictureBoxShowType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShowType.TabIndex = 10;
            this.pictureBoxShowType.TabStop = false;
            // 
            // EditComponentTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 716);
            this.Controls.Add(this.textboxPicLocation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxTypes);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.btnChoosePic);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.pictureBoxShowType);
            this.Controls.Add(this.labelShowImage);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Name = "EditComponentTypesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "עריכת סוגי רכיבים";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.EditComponentTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroLabel labelIndex;
        private MetroFramework.Controls.MetroLabel labelName;
        private MetroFramework.Controls.MetroLabel labelSize;
        private MetroFramework.Controls.MetroTextBox textboxName;
        private MetroFramework.Controls.MetroLabel labelShowImage;
        private System.Windows.Forms.PictureBox pictureBoxShowType;
        private MetroFramework.Controls.MetroLabel labelID;
        private MetroFramework.Controls.MetroButton btnChoosePic;
        private MetroFramework.Controls.MetroComboBox comboBoxSize;
        private System.Windows.Forms.ListBox listBoxTypes;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox textboxPicLocation;
        private System.Windows.Forms.OpenFileDialog choosePicDialog;
    }
}