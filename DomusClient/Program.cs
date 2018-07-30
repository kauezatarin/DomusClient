using System;
using System.Windows.Forms;

namespace DomusClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("pt-BR");
            Application.CurrentCulture = cultureInfo;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
