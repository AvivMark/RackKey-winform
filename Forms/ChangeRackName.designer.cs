namespace RackKeyV07
{
    partial class ChangeRackName
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
            this.tBoxEditName = new System.Windows.Forms.RichTextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.labelChangeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxEditName
            // 
            this.tBoxEditName.Location = new System.Drawing.Point(76, 66);
            this.tBoxEditName.Name = "tBoxEditName";
            this.tBoxEditName.Size = new System.Drawing.Size(261, 29);
            this.tBoxEditName.TabIndex = 0;
            this.tBoxEditName.Text = "";
            // 
            // btnChange
            // 
            this.btnChange.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnChange.Location = new System.Drawing.Point(170, 101);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "שנה";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.change_Click);
            // 
            // labelChangeName
            // 
            this.labelChangeName.AutoSize = true;
            this.labelChangeName.Location = new System.Drawing.Point(343, 73);
            this.labelChangeName.Name = "labelChangeName";
            this.labelChangeName.Size = new System.Drawing.Size(50, 13);
            this.labelChangeName.TabIndex = 2;
            this.labelChangeName.Text = "שם ארון";
            // 
            // ChangeRackName
            // 
            this.AcceptButton = this.btnChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 140);
            this.Controls.Add(this.labelChangeName);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tBoxEditName);
            this.Name = "ChangeRackName";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "שינוי שם ארון תקשורת";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ChangeRackName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tBoxEditName;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label labelChangeName;
    }
}