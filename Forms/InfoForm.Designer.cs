namespace RackKeyV07.Forms
{
    partial class InfoForm
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
            this.panelInfo = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVersionTitle = new System.Windows.Forms.Label();
            this.labelVersionNum = new System.Windows.Forms.Label();
            this.labelCopyrights = new System.Windows.Forms.Label();
            this.labelCopyRightContinue = new System.Windows.Forms.Label();
            this.labelSoftwareName = new System.Windows.Forms.Label();
            this.labelThanks1 = new System.Windows.Forms.Label();
            this.labelThanks2 = new System.Windows.Forms.Label();
            this.labelThanks3 = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelThanks3);
            this.panelInfo.Controls.Add(this.labelThanks2);
            this.panelInfo.Controls.Add(this.labelThanks1);
            this.panelInfo.Controls.Add(this.labelSoftwareName);
            this.panelInfo.Controls.Add(this.labelCopyRightContinue);
            this.panelInfo.Controls.Add(this.labelCopyrights);
            this.panelInfo.Controls.Add(this.labelVersionNum);
            this.panelInfo.Controls.Add(this.labelVersionTitle);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.HorizontalScrollbarBarColor = true;
            this.panelInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.panelInfo.HorizontalScrollbarSize = 10;
            this.panelInfo.Location = new System.Drawing.Point(23, 63);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(754, 364);
            this.panelInfo.TabIndex = 0;
            this.panelInfo.VerticalScrollbarBarColor = true;
            this.panelInfo.VerticalScrollbarHighlightOnWheel = false;
            this.panelInfo.VerticalScrollbarSize = 10;
            this.panelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RackKeyV07.Properties.Resources.RackKeyImage;
            this.pictureBox1.Location = new System.Drawing.Point(414, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelVersionTitle
            // 
            this.labelVersionTitle.AutoSize = true;
            this.labelVersionTitle.Location = new System.Drawing.Point(17, 49);
            this.labelVersionTitle.Name = "labelVersionTitle";
            this.labelVersionTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelVersionTitle.Size = new System.Drawing.Size(42, 13);
            this.labelVersionTitle.TabIndex = 3;
            this.labelVersionTitle.Text = "Version";
            // 
            // labelVersionNum
            // 
            this.labelVersionNum.AutoSize = true;
            this.labelVersionNum.Location = new System.Drawing.Point(64, 49);
            this.labelVersionNum.Name = "labelVersionNum";
            this.labelVersionNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelVersionNum.Size = new System.Drawing.Size(22, 13);
            this.labelVersionNum.TabIndex = 4;
            this.labelVersionNum.Text = "0.7";
            // 
            // labelCopyrights
            // 
            this.labelCopyrights.AutoSize = true;
            this.labelCopyrights.Location = new System.Drawing.Point(17, 83);
            this.labelCopyrights.Name = "labelCopyrights";
            this.labelCopyrights.Size = new System.Drawing.Size(91, 13);
            this.labelCopyrights.TabIndex = 5;
            this.labelCopyrights.Text = "©2020 Aviv Mark";
            // 
            // labelCopyRightContinue
            // 
            this.labelCopyRightContinue.AutoSize = true;
            this.labelCopyRightContinue.Location = new System.Drawing.Point(17, 122);
            this.labelCopyRightContinue.Name = "labelCopyRightContinue";
            this.labelCopyRightContinue.Size = new System.Drawing.Size(103, 13);
            this.labelCopyRightContinue.TabIndex = 6;
            this.labelCopyRightContinue.Text = "All Rights Reserved.";
            // 
            // labelSoftwareName
            // 
            this.labelSoftwareName.AutoSize = true;
            this.labelSoftwareName.Location = new System.Drawing.Point(17, 14);
            this.labelSoftwareName.Name = "labelSoftwareName";
            this.labelSoftwareName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSoftwareName.Size = new System.Drawing.Size(78, 13);
            this.labelSoftwareName.TabIndex = 7;
            this.labelSoftwareName.Text = "RackKey 2020";
            // 
            // labelThanks1
            // 
            this.labelThanks1.AutoSize = true;
            this.labelThanks1.Location = new System.Drawing.Point(17, 278);
            this.labelThanks1.Name = "labelThanks1";
            this.labelThanks1.Size = new System.Drawing.Size(222, 13);
            this.labelThanks1.TabIndex = 8;
            this.labelThanks1.Text = "Thanks to Vered Mark for the Graphic Design";
            // 
            // labelThanks2
            // 
            this.labelThanks2.AutoSize = true;
            this.labelThanks2.Location = new System.Drawing.Point(17, 301);
            this.labelThanks2.Name = "labelThanks2";
            this.labelThanks2.Size = new System.Drawing.Size(199, 13);
            this.labelThanks2.TabIndex = 9;
            this.labelThanks2.Text = "Thanks to Roi Kimchi for the Crazy Ideas";
            // 
            // labelThanks3
            // 
            this.labelThanks3.AutoSize = true;
            this.labelThanks3.Location = new System.Drawing.Point(17, 338);
            this.labelThanks3.Name = "labelThanks3";
            this.labelThanks3.Size = new System.Drawing.Size(147, 13);
            this.labelThanks3.TabIndex = 10;
            this.labelThanks3.Text = "Thanks to Icon8For the Icons";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.Resizable = false;
            this.Text = "About RackKey";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelInfo;
        private System.Windows.Forms.Label labelVersionTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSoftwareName;
        private System.Windows.Forms.Label labelCopyRightContinue;
        private System.Windows.Forms.Label labelCopyrights;
        private System.Windows.Forms.Label labelVersionNum;
        private System.Windows.Forms.Label labelThanks2;
        private System.Windows.Forms.Label labelThanks1;
        private System.Windows.Forms.Label labelThanks3;
    }
}