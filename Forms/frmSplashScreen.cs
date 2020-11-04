using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackKeyV07.Forms
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval>=3000)
            {
                timer1.Stop();
            }
            else
            {
                metroProgressBar1.PerformStep();
            }
        }

        public void CloseSplash()
        {
            Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
        }
        private void pictureBoxSplash_Click(object sender, EventArgs e)
        {

        }
    }
}
