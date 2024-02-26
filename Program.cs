using Project_Pulse.DL;
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
            //Application.Run(new loading_page());
            //Application.Run(new message_form("Error", "Unable  to  save  Group:  Invalid  Data", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Project_Pulse.Properties.Resources.close_circle_light));         
            //Application.Run(new manager_main_page());
            Essentials.SendEmail("6hafizmuhammadahmad6@gmail.com", "test", "new");
            Application.Run(new login_form());


        }
    }
}
