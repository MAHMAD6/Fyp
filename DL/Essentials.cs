using Project_Pulse.BL;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Mail;

namespace Project_Pulse.DL
{
    public enum LOOKUP
    {
        NULL = 0,
        MALE = 1,
        FEMALE,
        ACTIVE,
        INACTIVE,
        PROFESSOR,
        ASSOCIATE,
        ASSISTANT,
        LECTURER,
        INDUSTRY_PROFESSIONAL,
        MAIN_ADVISOR,
        CO_ADVISOR,
        INDUSTRY_ADVISOR,
        OTHER,
    }
    public enum TYPE
    {
        SIGN_IN,
        ASSISTANT_ANGRY,
        ASSISTANT_INJURED,
        SIGN_ID,
        SIGN_UP,
        FIRSTNAME,
        LASTNAME,
        EMAIL,
        CONTACT,
        GENDER,
        DATEOFBIRTH,
        ROLLNUMBER,
        ID,
        MALE,
        FEMALE,
        OTHER_GENDER
    }
    public class Essentials
    {
        public static Color TextColor = ColorTranslator.FromHtml("#d1d0c5");

        public static Color Panel_light = ColorTranslator.FromHtml("#323437");
        public static Color panel_dark = ColorTranslator.FromHtml("#ca4754");
        public static Color panel_border_top = MainColor;
        public static Color heading_ = TextColor;
        public static Color text_ = TextColor;
        public static Color text_unhighlighted = TextColor;
        public static string AppName { get; } = "Project Navigator";
        public static string MyName { get; } = "M Ahmad";
        public static string MyRole { get; } = "Creator";
        public static string subject_signUp { get; } = "Welcome to Project Navigator!";
        public static string GetBodySignUP(Student student)
        {
            return $"Dear {student.FirstName},\r\n\r\nWelcome to {AppName} – your go-to platform for managing your academic projects!" +
                    $"\r\n\r\nCongratulations on joining us! With {AppName}, you now have the tools to streamline your projects, collaborate effectively, " +
                    $"and excel in your academic pursuits.\r\n\n{student.RollNumber}\n\n\r\nHere's what we offer:\r\n\r\nProject Dashboard: Organize and track your projects effortlessly." +
                    $"\r\nCollaboration: Work seamlessly with peers and share files in real-time.\r\nDeadline Management: Stay on top of deadlines with customizable " +
                    $"reminders.\r\nResource Library: Access educational resources to enhance your projects.\r\nSupport: Our team is here to assist you whenever you " +
                    $"need help.\r\nGet started today and unlock your academic potential with {AppName}. If you have any questions, feel free to reach out –" +
                    $" we're here for you!\r\n\r\nBest regards,\r\n\r\n{MyName}\r\n{MyRole}\r\n{AppName} Team";

        }
        public static Color BgColor { get; } = ColorTranslator.FromHtml("#323437");
        public static Color MainColor { get; } = ColorTranslator.FromHtml("#e2b 714");
        public static Color CaretColor { get; } = ColorTranslator.FromHtml("#e2b714");
        public static Color SubColor { get; } = ColorTranslator.FromHtml("#646669");
        public static Color SubAltColor = ColorTranslator.FromHtml("#2c2e31");
        public static Color ErrorColor { get; } = ColorTranslator.FromHtml("#ca4754");
        public static Color ErrorExtraColor { get; } = ColorTranslator.FromHtml("#7e2a33");
        public static string SqlConnectionString { get; } = "Data Source=MYLAPTOP;Initial Catalog=ProjectA;Integrated Security=True";
        public static Bitmap ChangeOpacity_img(Image img, float opacity)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // Set the opacity

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                gfx.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);
            }

            return bmp;
        }
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
                //MessageBox.Show($"{ex}", " !!error");
            }
        }
    }
}
