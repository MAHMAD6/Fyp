using Project_Pulse.DL;
using Project_Pulse.Properties;
using Project_Pulse.UI.FORMS;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Project_Pulse
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static TYPE formToinvoke;
        public static Thread emailSuccess;
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application Flow
            emailSuccess = new Thread(() =>
            {
                // Create and show the form on the new thread
                form_message formMessage = new form_message("Email Sent", "You Reg. No sent to you: Email", Color_.green, Color_.green_dark, Resources.email_light);
                Application.Run(formMessage);
            });
            //Application.Run(new loading_page());
            while (formToinvoke != TYPE.CLOSE)
            {
                Application.Run(new form_login());
                switch (formToinvoke)
                {
                    case TYPE.STUDENT:
                        Application.Run(new form_manage_student());
                        break;
                    case TYPE.ADVISOR:
                        Application.Run(new form_manager_main_page());
                        break;
                }

            }



            //Application.Exit();
            //Application.Run(new loading_page());
            //Application.Run(new message_form("Error", "Unable  to  save  Group:  Invalid  Data", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Project_Pulse.Properties.Resources.close_circle_light));         

            //Application.Run(new form_credentials());
            //Application.Run(new form_login());
            //Application.Run(new form_manage_student());
            //Application.Run(new form_manager_main_page());

        }
    }
}
