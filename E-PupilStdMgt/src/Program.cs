using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_PupilStdMgt.forms;
using E_PupilStdMgt.src.controller.forms;

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
            // Application.Run(new RolePickingForm());
            Application.Run(new AdminDashboardForm());
            //Application.Run(new StuffDashboardForm());
        }
    }
}
