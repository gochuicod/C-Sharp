using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm f1 = new MainForm();
            f1.FormBorderStyle = FormBorderStyle.FixedDialog;
            f1.MinimizeBox = false;
            f1.MaximizeBox = false;
            f1.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(f1);
        }
    }
}
