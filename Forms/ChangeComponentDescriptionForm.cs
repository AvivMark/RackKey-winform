using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackKeyV07.Forms
{
    public partial class ChangeComponentDescriptionForm : MetroFramework.Forms.MetroForm
    {
        private Component cmp;
        public ChangeComponentDescriptionForm(Component cmp)
        {
            InitializeComponent();
            this.cmp = cmp;
        }

        private void ChangeComponentDescriptionForm_Load(object sender, EventArgs e)
        {
            richTextBoxDesc.Text = cmp.descriptionLabelText; 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cmp.UpdateDescription(richTextBoxDesc.Text);
            Close();
        }
    }
}
