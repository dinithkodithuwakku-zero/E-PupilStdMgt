using System;
using System.Windows.Forms;
using E_PupilStdMgt.forms;

namespace E_PupilStdMgt
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RolePickingForm());
        }
    }
}
