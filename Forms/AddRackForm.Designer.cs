namespace RackKeyV07
{
    partial class AddRackForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnSelectPicture = new MetroFramework.Controls.MetroButton();
            this.labelPicture = new MetroFramework.Controls.MetroLabel();
            this.labelSize = new MetroFramework.Controls.MetroLabel();
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.textBoxPicture = new MetroFramework.Controls.MetroTextBox();
            this.textBoxName = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxSize = new MetroFramework.Controls.MetroComboBox();
            this.toolTipSize = new MetroFramework.Components.MetroToolTip();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxRack = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(118, 328);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "הוסף";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBoxRack);
            this.metroPanel1.Controls.Add(this.btnSelectPicture);
            this.metroPanel1.Controls.Add(this.labelPicture);
            this.metroPanel1.Controls.Add(this.labelSize);
            this.metroPanel1.Controls.Add(this.labelName);
            this.metroPanel1.Controls.Add(this.textBoxPicture);
            this.metroPanel1.Controls.Add(this.textBoxName);
            this.metroPanel1.Controls.Add(this.comboBoxSize);
            this.metroPanel1.Controls.Add(this.btnOK);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(14, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(362, 364);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(15, 120);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(50, 26);
            this.btnSelectPicture.TabIndex = 8;
            this.btnSelectPicture.Text = "בחר";
            this.btnSelectPicture.UseSelectable = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelPicture.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPicture.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.labelPicture.Location = new System.Drawing.Point(255, 119);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(98, 25);
            this.labelPicture.TabIndex = 7;
            this.labelPicture.Text = "תמונת ארון";
            this.labelPicture.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelSize.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelSize.Location = new System.Drawing.Point(279, 69);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(80, 25);
            this.labelSize.TabIndex = 6;
            this.labelSize.Text = "גודל ארון";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelName.Location = new System.Drawing.Point(285, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 25);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "שם ארון";
            // 
            // textBoxPicture
            // 
            // 
            // 
            // 
            this.textBoxPicture.CustomButton.Image = null;
            this.textBoxPicture.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.textBoxPicture.CustomButton.Name = "";
            this.textBoxPicture.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPicture.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPicture.CustomButton.TabIndex = 1;
            this.textBoxPicture.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPicture.CustomButton.UseSelectable = true;
            this.textBoxPicture.CustomButton.Visible = false;
            this.textBoxPicture.Lines = new string[] {
        "מיקום תמונה"};
            this.textBoxPicture.Location = new System.Drawing.Point(66, 122);
            this.textBoxPicture.MaxLength = 32767;
            this.textBoxPicture.Name = "textBoxPicture";
            this.textBoxPicture.PasswordChar = '\0';
            this.textBoxPicture.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPicture.SelectedText = "";
            this.textBoxPicture.SelectionLength = 0;
            this.textBoxPicture.SelectionStart = 0;
            this.textBoxPicture.ShortcutsEnabled = true;
            this.textBoxPicture.Size = new System.Drawing.Size(178, 23);
            this.textBoxPicture.TabIndex = 4;
            this.textBoxPicture.Text = "מיקום תמונה";
            this.textBoxPicture.UseSelectable = true;
            this.textBoxPicture.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPicture.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxName
            // 
            // 
            // 
            // 
            this.textBoxName.CustomButton.Image = null;
            this.textBoxName.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textBoxName.CustomButton.Name = "";
            this.textBoxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxName.CustomButton.TabIndex = 1;
            this.textBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxName.CustomButton.UseSelectable = true;
            this.textBoxName.CustomButton.Visible = false;
            this.textBoxName.Lines = new string[] {
        "שם ארון"};
            this.textBoxName.Location = new System.Drawing.Point(123, 25);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxName.SelectedText = "";
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.ShortcutsEnabled = true;
            this.textBoxName.Size = new System.Drawing.Size(121, 23);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Text = "שם ארון";
            this.textBoxName.UseSelectable = true;
            this.textBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.ItemHeight = 23;
            this.comboBoxSize.Location = new System.Drawing.Point(186, 69);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(58, 29);
            this.comboBoxSize.TabIndex = 2;
            this.comboBoxSize.UseSelectable = true;
            // 
            // toolTipSize
            // 
            this.toolTipSize.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolTipSize.StyleManager = null;
            this.toolTipSize.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "OpenPictureDialog";
            this.openPictureDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openPictureDialog_FileOk);
            // 
            // pictureBoxRack
            // 
            this.pictureBoxRack.Location = new System.Drawing.Point(106, 164);
            this.pictureBoxRack.Name = "pictureBoxRack";
            this.pictureBoxRack.Size = new System.Drawing.Size(138, 134);
            this.pictureBoxRack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRack.TabIndex = 9;
            this.pictureBoxRack.TabStop = false;
            // 
            // AddRackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "AddRackForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ארון חדש";
            this.Load += new System.EventHandler(this.AddRackForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel labelPicture;
        private MetroFramework.Controls.MetroLabel labelSize;
        private MetroFramework.Controls.MetroLabel labelName;
        private MetroFramework.Controls.MetroTextBox textBoxPicture;
        private MetroFramework.Controls.MetroTextBox textBoxName;
        private MetroFramework.Controls.MetroComboBox comboBoxSize;
        private MetroFramework.Controls.MetroButton btnSelectPicture;
        private MetroFramework.Components.MetroToolTip toolTipSize;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.PictureBox pictureBoxRack;
    }
}