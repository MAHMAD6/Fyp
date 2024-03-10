using System.Drawing;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class uc_message_for_controls : UserControl
    {
        public uc_message_for_controls(string message, int size, int x, int y)
        {
            InitializeComponent();
            label_menu_header.Text = message;
            label_menu_header.Location = new Point(x, y);
            label_menu_header.Font = new Font(label_menu_header.Font.FontFamily, size, FontStyle.Regular);

        }
        public void SET_size(int height, int width)
        {
            if (height == 0 && width == 0)
            {
                this.Size = new Size(this.Width, label_menu_header.Height + 10);
                return;
            }
            this.Size = new Size(width, height);
        }
    }
}
