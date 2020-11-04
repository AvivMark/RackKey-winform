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
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            labelRoomSize.RightToLeft = RightToLeft.Yes;
            textBoxLength.Text = Properties.Settings.Default.RoomLength.ToString();
            textBoxWidth.Text = Properties.Settings.Default.RoomWidth.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBoxLength.Text != Properties.Settings.Default.RoomLength.ToString())
            {
                Properties.Settings.Default.RoomLength = int.Parse(textBoxLength.Text);
            }
            if (textBoxWidth.Text != Properties.Settings.Default.RoomWidth.ToString())
            {
                Properties.Settings.Default.RoomWidth = int.Parse(textBoxWidth.Text);
            }

            Properties.Settings.Default.Save();
            MainRoomView.ActiveForm.Refresh();
            this.Close();
        }
    }
}
