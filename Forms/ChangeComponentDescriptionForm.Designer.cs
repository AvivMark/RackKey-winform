namespace RackKeyV07.Forms
{
    partial class ChangeComponentDescriptionForm
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
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.labelDesc = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(160, 63);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(430, 60);
            this.richTextBoxDesc.TabIndex = 1;
            this.richTextBoxDesc.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(268, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "שנה";
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(73, 84);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(41, 19);
            this.labelDesc.TabIndex = 3;
            this.labelDesc.Text = "תיאור";
            // 
            // ChangeComponentDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 195);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.richTextBoxDesc);
            this.Name = "ChangeComponentDescriptionForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "שינוי תיאור רכיב";
            this.Load += new System.EventHandler(this.ChangeComponentDescriptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroLabel labelDesc;
    }
}