using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackKeyV07
{
    public partial class ChangeRackName : MetroFramework.Forms.MetroForm
    {
        public ChangeRackName()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (Globs.rackClicked!=null)
            {
                Rack rk = Globs.rackClicked;
                string oldName = rk.name;
                rk.name = tBoxEditName.Text;
                Main.UpdateRackName(rk, tBoxEditName.Text);
                rk.control.Text = rk.name;
                rk.control.Refresh();
                ChangeRackName.ActiveForm.Close();
                
            }
            else
            {

            }
        }

        private void ChangeRackName_Load(object sender, EventArgs e)
        {
            try
            {
                tBoxEditName.Text = Globs.rackClicked.name;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                Application.Exit();
            }
        }
    }
}
