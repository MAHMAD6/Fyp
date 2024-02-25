using Project_Pulse.UI.FORMS;
using System;
using System.Windows.Forms;

namespace Project_Pulse
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loading_page());

        }
    }
}
