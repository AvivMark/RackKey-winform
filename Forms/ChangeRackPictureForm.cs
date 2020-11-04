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
    public partial class ChangeRackPictureForm : MetroFramework.Forms.MetroForm
    {
        bool VerificationPass = false;
        public ChangeRackPictureForm()
        {
            InitializeComponent();
        }

        private void ChangeRackPictureForm_Load(object sender, EventArgs e)
        {
            pictureBoxCurrent.Image = Globs.rackClicked.rackPicture;
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (VerificationPass)
            {
                try
                {
                    Globs.main.SetRackImage(openPictureDialog.FileName, Globs.rackClicked);
                    Globs.rackClicked.control.Refresh();
                    Close();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("יש בעיה עם בחירת התמונה בחר מחדש או סגור את החלון");
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            openPictureDialog.Filter = Globs.PictureFilter;
            openPictureDialog.ShowDialog();
        }

        private void openPictureDialog_FileOk(object sender, CancelEventArgs e)
        {
            string picFilePath = openPictureDialog.FileName;
            if (openPictureDialog.FileName!=null)
            {
                if (File.Exists(openPictureDialog.FileName))
                {
                    Image img =  Project.GetCorrectedImage(openPictureDialog.FileName);
                    pictureBoxNew.Image = img ;
                    textBoxPicFilePath.Text = picFilePath;
                    VerificationPass = true;
                }
                else
                {
                    MessageBox.Show("בעיה בגישה למיקום התמונה");
                }
            }
            else
            {
                MessageBox.Show("לא נבחרה תמונה");
            }
        }

        private void pictureBoxNew_Click(object sender, EventArgs e)
        {

        }
    }
}
