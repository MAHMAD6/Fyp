using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Pulse.UI.FORMS
{
    public partial class form_message : Form
    {
        string messageHeading;
        string messagetext;
        Image messageIcon;
        public form_message(string messageHeading, string messagetext, Color borderColor, Color bgColor, Image messageIcon)
        {
            InitializeComponent();

            this.Opacity = 100;

            StartPosition = FormStartPosition.Manual;

            // When use clicks on message form it close
            panel_back.Click += close_message;
            label_dark.Click += close_message;
            label_light.Click += close_message;


            // hovers
            panel_back.MouseEnter += hover_message_mouse_enter;
            panel_back.MouseLeave += hover_message_mouse_leave;
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
            this.messageIcon = messageIcon;
            // COLORING
            this.BackColor = borderColor;
            panel_back.BackColor = bgColor;
            panel_back.BaseColor = bgColor;
            label_dark.BackColor = bgColor;
            label_light.BackColor = bgColor;
            PB_message_icon.BackColor = bgColor;
            this.BackColor = borderColor;
            panel_back.Radius = 6;
            // form elements initialization
            label_dark.Text = messageHeading;
            label_light.Text = messagetext;
            PB_message_icon.Image = messageIcon;
        }

        int count_toClose = 0;


        void hover_message_mouse_enter(object sender, EventArgs e)
        {
            PB_message_icon.Image = Project_Pulse.Properties.Resources.close_light;
            label_dark.Text = "close";
            label_light.Text = "Close  the  current  message:  click!"; ;
            panel_back.Radius = 15;
        }
        void hover_message_mouse_leave(object sender, EventArgs e)
        {
            panel_back.Radius = 6;
            PB_message_icon.Image = messageIcon;
            label_dark.Text = messageHeading;
            label_light.Text = messagetext;
        }
        void close_message(object sender, EventArgs e)
        {
            this.Close();
        }

        private void to_close_Tick(object sender, EventArgs e)
        {
            if (count_toClose == 9)
                this.Close();
            count_toClose++;
        }
    }
}
