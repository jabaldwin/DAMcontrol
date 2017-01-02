using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace LabLockWinForms
{
    static public class Program
    {
        public static bool successfulLogin = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LabLockWindow());
        }

        [STAThread]
        public static bool Start()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            LabLockWindow win = new LabLockWindow();
            win.ShowDialog();

            return successfulLogin;
        }
    }
}
