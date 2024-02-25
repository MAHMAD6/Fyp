using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Pulse.UI.FORMS
{
    public partial class message_form : Form
    {
        string messageHeading;
        string messagetext;
        Color borderColor;
        Color bgColor;
        Image messageIcon;
        public message_form(string messageHeading, string messagetext, Color borderColor, Color bgColor, Image messageIcon)
        {
            InitializeComponent();

            timeToClose = 0;

            //this.Visible = true;
            this.Opacity = 0;
            StartPosition = FormStartPosition.Manual;

            // When use clicks on message form it close
            gunaShadowPanel.Click += close_message;
            label_dark.Click += close_message;
            label_light.Click += close_message;


            // hovers
            gunaShadowPanel.MouseEnter += hover_message_mouse_enter;
            gunaShadowPanel.MouseLeave += hover_message_mouse_leave;
            label_light.MouseEnter += hover_message_mouse_enter;
            label_light.MouseLeave += hover_message_mouse_leave;
            label_dark.MouseEnter += hover_message_mouse_enter;
            label_dark.MouseLeave += hover_message_mouse_leave;
            PB_message_icon.MouseEnter += hover_message_mouse_enter;
            PB_message_icon.MouseLeave += hover_message_mouse_leave;

            // This will move form in bottom-right corner
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = Width;
            int formHeight = Height;
            int formX = screenWidth - formWidth - 4;
            int formY = screenHeight - formHeight - 4;
            Location = new Point(formX, formY);
            this.TopMost = true;

            // requirements
            this.messageHeading = messageHeading;
            this.messagetext = messagetext;
            this.borderColor = borderColor;
            this.bgColor = bgColor;
            this.messageIcon = messageIcon;
        }

        // Fade is still in progress
        int timeToClose = 0;
        private void timer_fade_form_Tick(object sender, EventArgs e)
        {
            if (timeToClose == 50)
                this.Close();
            timeToClose++;
            if (this.Opacity < 100)
            {
                this.Opacity += 3;
            }
        }

        void hover_message_mouse_enter(object sender, EventArgs e)
        {
            PB_message_icon.Image = Project_Pulse.Properties.Resources.close_light;
            label_dark.Text = "close";
            label_light.Text = "Close  the  current  message:  click!"; ;
            gunaShadowPanel.Radius = 15;
        }
        void hover_message_mouse_leave(object sender, EventArgs e)
        {
            gunaShadowPanel.Radius = 6;
            PB_message_icon.Image = messageIcon;
            label_dark.Text = messageHeading;
            label_light.Text = messagetext;
        }
        void close_message(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
