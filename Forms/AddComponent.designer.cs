namespace RackKeyV07
{
    partial class AddComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComponent));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelDesc = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelChooseImage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddType = new MetroFramework.Controls.MetroLink();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxComponent = new System.Windows.Forms.PictureBox();
            this.comboBoxImages = new MetroFramework.Controls.MetroComboBox();
            this.imageListComponents = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComponent)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(254, 227);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "הוסף";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(509, 31);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDesc.Size = new System.Drawing.Size(69, 13);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "תיאור רכיב:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(79, 27);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDescription.Size = new System.Drawing.Size(412, 20);
            this.textBoxDescription.TabIndex = 2;
            // 
            // labelChooseImage
            // 
            this.labelChooseImage.AutoSize = true;
            this.labelChooseImage.Location = new System.Drawing.Point(497, 73);
            this.labelChooseImage.Name = "labelChooseImage";
            this.labelChooseImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelChooseImage.Size = new System.Drawing.Size(81, 13);
            this.labelChooseImage.TabIndex = 5;
            this.labelChooseImage.Text = "בחר דגם רכיב:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddType);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBoxComponent);
            this.groupBox1.Controls.Add(this.comboBoxImages);
            this.groupBox1.Controls.Add(this.labelChooseImage);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.labelDesc);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(589, 259);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnAddType
            // 
            this.btnAddType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddType.Image = global::RackKeyV07.Properties.Resources.AddIconTypeHover;
            this.btnAddType.ImageSize = 50;
            this.btnAddType.Location = new System.Drawing.Point(17, 53);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.NoFocusImage = global::RackKeyV07.Properties.Resources.AddIconType;
            this.btnAddType.Size = new System.Drawing.Size(56, 62);
            this.btnAddType.TabIndex = 13;
            this.btnAddType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddType.UseSelectable = true;
            this.btnAddType.Click += new System.EventHandler(this.AddTypeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "תצוגת רכיב:";
            // 
            // pictureBoxComponent
            // 
            this.pictureBoxComponent.Location = new System.Drawing.Point(79, 115);
            this.pictureBoxComponent.Name = "pictureBoxComponent";
            this.pictureBoxComponent.Size = new System.Drawing.Size(412, 88);
            this.pictureBoxComponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxComponent.TabIndex = 11;
            this.pictureBoxComponent.TabStop = false;
            // 
            // comboBoxImages
            // 
            this.comboBoxImages.DisplayFocus = true;
            this.comboBoxImages.FormattingEnabled = true;
            this.comboBoxImages.ItemHeight = 23;
            this.comboBoxImages.Location = new System.Drawing.Point(79, 65);
            this.comboBoxImages.Name = "comboBoxImages";
            this.comboBoxImages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxImages.Size = new System.Drawing.Size(412, 29);
            this.comboBoxImages.Sorted = true;
            this.comboBoxImages.TabIndex = 9;
            this.comboBoxImages.UseSelectable = true;
            this.comboBoxImages.SelectedIndexChanged += new System.EventHandler(this.comboBoxImages_SelectedIndexChanged);
            this.comboBoxImages.SelectionChangeCommitted += new System.EventHandler(this.comboBoxImages_SelectionChangeCommitted);
            // 
            // imageListComponents
            // 
            this.imageListComponents.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListComponents.ImageStream")));
            this.imageListComponents.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListComponents.Images.SetKeyName(0, "48PortPanel.jpeg");
            this.imageListComponents.Images.SetKeyName(1, "Catalyst 2960 48port.jpg");
            this.imageListComponents.Images.SetKeyName(2, "cisco Catalyst 2960 24port.jpg");
            this.imageListComponents.Images.SetKeyName(3, "computer-155960_640.png");
            this.imageListComponents.Images.SetKeyName(4, "computer-158777_1280.png");
            this.imageListComponents.Images.SetKeyName(5, "computer-158930_640.png");
            this.imageListComponents.Images.SetKeyName(6, "ethernet-156573_640.png");
            this.imageListComponents.Images.SetKeyName(7, "ethernet-161588_640.png");
            this.imageListComponents.Images.SetKeyName(8, "ibm-161589_640.png");
            this.imageListComponents.Images.SetKeyName(9, "juniper_router_m7.jpg");
            this.imageListComponents.Images.SetKeyName(10, "mainframe-156011_640.png");
            this.imageListComponents.Images.SetKeyName(11, "Netapp.jpg");
            this.imageListComponents.Images.SetKeyName(12, "server-36950_640.png");
            // 
            // AddComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 322);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddComponent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הוספת רכיב";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddComponent_FormClosing);
            this.Load += new System.EventHandler(this.AddComponent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComponent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelChooseImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageListComponents;
        private MetroFramework.Controls.MetroComboBox comboBoxImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxComponent;
        private MetroFramework.Controls.MetroLink btnAddType;
    }
}