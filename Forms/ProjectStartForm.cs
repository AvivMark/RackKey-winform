using RackKeyV07;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackKeyV07
{
    public partial class ProjectStartForm : MetroFramework.Forms.MetroForm
    {
        public ProjectStartForm()
        {
            InitializeComponent();
        }

        private void ProjectStartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {   
            string dummyFileName = "rackKeySaveFile";
            NewProjectDialog.Filter = "RackKey(*.rky*)|*.*";
            NewProjectDialog.AddExtension = false;
            NewProjectDialog.FileName = dummyFileName;
            NewProjectDialog.CheckFileExists = false;
            if (NewProjectDialog.ShowDialog() == DialogResult.OK)
            {


                string fileName = Path.GetFileName(NewProjectDialog.FileName);
                Globs.CurrentProject = new Project(NewProjectDialog.FileName, false);                
                this.Hide();              
                Globs.activeMainForm = new MainRoomView();

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openProjetcFileDialog.Filter = "RackKey(*.rky*)|*.rky*";
            if (openProjetcFileDialog.ShowDialog()== DialogResult.OK)
            {
                string fileName = Path.GetFileName(openProjetcFileDialog.FileName);
                Globs.CurrentProject = new Project(openProjetcFileDialog.FileName, true);
                this.Hide();
                Globs.activeMainForm = new MainRoomView();
            }
        }
    }
}
