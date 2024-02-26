using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Project_Pulse.DL
{
    internal class Essentials
    {
        public Color BgColor { get; } = ColorTranslator.FromHtml("#323437");
        public Color MainColor { get; } = ColorTranslator.FromHtml("#e2b714");
        public Color CaretColor { get; } = ColorTranslator.FromHtml("#e2b714");
        public Color SubColor { get; } = ColorTranslator.FromHtml("#646669");
        public Color SubAltColor { get; } = ColorTranslator.FromHtml("#2c2e31");
        public Color TextColor { get; } = ColorTranslator.FromHtml("#d1d0c5");
        public Color ErrorColor { get; } = ColorTranslator.FromHtml("#ca4754");
        public Color ErrorExtraColor { get; } = ColorTranslator.FromHtml("#7e2a33");
        public Color ColorfulErrorColor { get; } = ColorTranslator.FromHtml("#ca4754");
        public Color ColorfulErrorExtraColor { get; } = ColorTranslator.FromHtml("#7e2a33");


        public static void SendEmail(String toEmailAddress, String Subject, String Body)
        {
            try
            {
                string fromEmail = "acstechyt@gmail.com";
                string password = "ztmfvquoxoljazec";
                int port = 587;
                string host = "smtp.gmail.com";
                using (MailMessage mail = new MailMessage(fromEmail, toEmailAddress, Subject, Body))
                {
                    using (SmtpClient smtp = new SmtpClient(host, port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(fromEmail, password);
                        smtp.Send(mail);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", " !!error");
            }
        }
    }
}
