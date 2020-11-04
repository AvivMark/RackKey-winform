using RackKeyV07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackKeyV07
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length>1)
            {
                OpenProjectFile(args[1]);
                Globs.activeMainForm = new MainRoomView();
                Application.Run(Globs.activeMainForm);
            }
            else
            {
                Application.Run(new ProjectStartForm());
            }
        }
        private static void OpenProjectFile(string path)
        {
            string name = System.IO.Path.GetFileName(path).Replace(Project.ProjectFileType,string.Empty);
            Project openProject = new Project(path, true);
        }
    }
}
