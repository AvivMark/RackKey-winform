using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackKeyV07
{
    public static class Globs
    {                       
        public static MainRoomView activeMainForm;       
        public static Main main = new Main();
        public static Project CurrentProject = null;
        public static readonly string PictureFilter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
        public static readonly Size defaultDecorationSIZE = new Size(100, 100);
        public static readonly Size stripSize = new Size(500, 50);
        public static readonly Size U1size = new Size(425, 50);
        public static readonly Size RackButtonSize = new Size(65, 150);
        public static readonly Font RackMainFont = new Font("Microsoft YaHei UI", 14, FontStyle.Bold, GraphicsUnit.Pixel);
        public static string SettingConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Properties.Settings.Default.DBLocation;
        //public static string TempConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data SourceC:\Users\aviv2\OneDrive\Desktop\מחשב נייח\Visual Studio Projects\ServerFarm\V0.6\AppData\FarmDB.accdb";
        public static System.Windows.Forms.Panel stripPanel = null;
        public static Rack rackClicked = null;        
        public static DBHandler DB = new DBHandler();


    }
}
