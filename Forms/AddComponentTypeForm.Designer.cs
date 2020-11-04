namespace RackKeyV07
{
    partial class AddComponentTypeForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPic = new System.Windows.Forms.Label();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.textBoxPicPath = new MetroFramework.Controls.MetroTextBox();
            this.textBoxName = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxSize = new MetroFramework.Controls.MetroComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChoosePic = new MetroFramework.Controls.MetroButton();
            this.picBoxComponent = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComponent)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnChoosePic);
            this.metroPanel1.Controls.Add(this.picBoxComponent);
            this.metroPanel1.Controls.Add(this.comboBoxSize);
            this.metroPanel1.Controls.Add(this.textBoxName);
            this.metroPanel1.Controls.Add(this.textBoxPicPath);
            this.metroPanel1.Controls.Add(this.btnOk);
            this.metroPanel1.Controls.Add(this.labelPic);
            this.metroPanel1.Controls.Add(this.labelName);
            this.metroPanel1.Controls.Add(this.labelSize);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(14, 76);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(469, 363);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(426, 94);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(32, 13);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "גודל";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(409, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "שם דגם:";
            // 
            // labelPic
            // 
            this.labelPic.AutoSize = true;
            this.labelPic.Location = new System.Drawing.Point(386, 159);
            this.labelPic.Name = "labelPic";
            this.labelPic.Size = new System.Drawing.Size(72, 13);
            this.labelPic.TabIndex = 4;
            this.labelPic.Text = "מיקום תמונה";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(182, 321);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 30);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "הוסף";
            this.btnOk.UseSelectable = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textBoxPicPath
            // 
            // 
            // 
            // 
            this.textBoxPicPath.CustomButton.Image = null;
            this.textBoxPicPath.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.textBoxPicPath.CustomButton.Name = "";
            this.textBoxPicPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPicPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPicPath.CustomButton.TabIndex = 1;
            this.textBoxPicPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPicPath.CustomButton.UseSelectable = true;
            this.textBoxPicPath.CustomButton.Visible = false;
            this.textBoxPicPath.Lines = new string[0];
            this.textBoxPicPath.Location = new System.Drawing.Point(72, 154);
            this.textBoxPicPath.MaxLength = 32767;
            this.textBoxPicPath.Name = "textBoxPicPath";
            this.textBoxPicPath.PasswordChar = '\0';
            this.textBoxPicPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPicPath.SelectedText = "";
            this.textBoxPicPath.SelectionLength = 0;
            this.textBoxPicPath.SelectionStart = 0;
            this.textBoxPicPath.ShortcutsEnabled = true;
            this.textBoxPicPath.Size = new System.Drawing.Size(308, 23);
            this.textBoxPicPath.TabIndex = 6;
            this.textBoxPicPath.UseSelectable = true;
            this.textBoxPicPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPicPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxName
            // 
            // 
            // 
            // 
            this.textBoxName.CustomButton.Image = null;
            this.textBoxName.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.textBoxName.CustomButton.Name = "";
            this.textBoxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxName.CustomButton.TabIndex = 1;
            this.textBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxName.CustomButton.UseSelectable = true;
            this.textBoxName.CustomButton.Visible = false;
            this.textBoxName.Lines = new string[0];
            this.textBoxName.Location = new System.Drawing.Point(226, 26);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxName.SelectedText = "";
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.ShortcutsEnabled = true;
            this.textBoxName.Size = new System.Drawing.Size(154, 23);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.UseSelectable = true;
            this.textBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.ItemHeight = 23;
            this.comboBoxSize.Location = new System.Drawing.Point(323, 87);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(57, 29);
            this.comboBoxSize.TabIndex = 8;
            this.comboBoxSize.UseSelectable = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnChoosePic
            // 
            this.btnChoosePic.Location = new System.Drawing.Point(13, 154);
            this.btnChoosePic.Name = "btnChoosePic";
            this.btnChoosePic.Size = new System.Drawing.Size(53, 23);
            this.btnChoosePic.TabIndex = 10;
            this.btnChoosePic.Text = "בחר";
            this.btnChoosePic.UseSelectable = true;
            this.btnChoosePic.Click += new System.EventHandler(this.btnChoosePic_Click);
            // 
            // picBoxComponent
            // 
            this.picBoxComponent.Location = new System.Drawing.Point(62, 196);
            this.picBoxComponent.Name = "picBoxComponent";
            this.picBoxComponent.Size = new System.Drawing.Size(327, 104);
            this.picBoxComponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxComponent.TabIndex = 9;
            this.picBoxComponent.TabStop = false;
            // 
            // AddComponentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 462);
            this.Controls.Add(this.metroPanel1);
            this.Name = "AddComponentTypeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הוספת סוג רכיב";
            this.Load += new System.EventHandler(this.AddComponentTypeForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComponent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnChoosePic;
        private System.Windows.Forms.PictureBox picBoxComponent;
        private MetroFramework.Controls.MetroComboBox comboBoxSize;
        private MetroFramework.Controls.MetroTextBox textBoxName;
        private MetroFramework.Controls.MetroTextBox textBoxPicPath;
        private MetroFramework.Controls.MetroButton btnOk;
        private System.Windows.Forms.Label labelPic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}