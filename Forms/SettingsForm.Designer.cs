namespace RackKeyV07
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.labelRoomSize = new MetroFramework.Controls.MetroLabel();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.textBoxLength = new MetroFramework.Controls.MetroTextBox();
            this.labelWidth = new MetroFramework.Controls.MetroLabel();
            this.labelLength = new MetroFramework.Controls.MetroLabel();
            this.textBoxWidth = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRoomSize
            // 
            this.labelRoomSize.AutoSize = true;
            this.labelRoomSize.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelRoomSize.Location = new System.Drawing.Point(290, 39);
            this.labelRoomSize.Name = "labelRoomSize";
            this.labelRoomSize.Size = new System.Drawing.Size(169, 25);
            this.labelRoomSize.TabIndex = 0;
            this.labelRoomSize.Text = "גודל החדר (במטרים):";
            this.labelRoomSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelRoomSize.WrapToLine = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(166, 322);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "החל שינויים";
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.textBoxLength);
            this.metroPanel1.Controls.Add(this.labelWidth);
            this.metroPanel1.Controls.Add(this.labelLength);
            this.metroPanel1.Controls.Add(this.textBoxWidth);
            this.metroPanel1.Controls.Add(this.btnOK);
            this.metroPanel1.Controls.Add(this.labelRoomSize);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(467, 370);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // textBoxLength
            // 
            // 
            // 
            // 
            this.textBoxLength.CustomButton.Image = null;
            this.textBoxLength.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.textBoxLength.CustomButton.Name = "";
            this.textBoxLength.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxLength.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxLength.CustomButton.TabIndex = 1;
            this.textBoxLength.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxLength.CustomButton.UseSelectable = true;
            this.textBoxLength.CustomButton.Visible = false;
            this.textBoxLength.Lines = new string[] {
        "metroTextBox2"};
            this.textBoxLength.Location = new System.Drawing.Point(282, 117);
            this.textBoxLength.MaxLength = 32767;
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.PasswordChar = '\0';
            this.textBoxLength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxLength.SelectedText = "";
            this.textBoxLength.SelectionLength = 0;
            this.textBoxLength.SelectionStart = 0;
            this.textBoxLength.ShortcutsEnabled = true;
            this.textBoxLength.Size = new System.Drawing.Size(104, 23);
            this.textBoxLength.TabIndex = 5;
            this.textBoxLength.Text = "metroTextBox2";
            this.textBoxLength.UseSelectable = true;
            this.textBoxLength.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxLength.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(408, 85);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(37, 19);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "רוחב";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(408, 117);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(40, 19);
            this.labelLength.TabIndex = 3;
            this.labelLength.Text = "אורך ";
            // 
            // textBoxWidth
            // 
            // 
            // 
            // 
            this.textBoxWidth.CustomButton.Image = null;
            this.textBoxWidth.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.textBoxWidth.CustomButton.Name = "";
            this.textBoxWidth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxWidth.CustomButton.TabIndex = 1;
            this.textBoxWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxWidth.CustomButton.UseSelectable = true;
            this.textBoxWidth.CustomButton.Visible = false;
            this.textBoxWidth.Lines = new string[] {
        "metroTextBox1"};
            this.textBoxWidth.Location = new System.Drawing.Point(282, 85);
            this.textBoxWidth.MaxLength = 32767;
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.PasswordChar = '\0';
            this.textBoxWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxWidth.SelectedText = "";
            this.textBoxWidth.SelectionLength = 0;
            this.textBoxWidth.SelectionStart = 0;
            this.textBoxWidth.ShortcutsEnabled = true;
            this.textBoxWidth.Size = new System.Drawing.Size(104, 23);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.Text = "metroTextBox1";
            this.textBoxWidth.UseSelectable = true;
            this.textBoxWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הגדרות";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelRoomSize;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox textBoxWidth;
        private MetroFramework.Controls.MetroTextBox textBoxLength;
        private MetroFramework.Controls.MetroLabel labelWidth;
        private MetroFramework.Controls.MetroLabel labelLength;
    }
}