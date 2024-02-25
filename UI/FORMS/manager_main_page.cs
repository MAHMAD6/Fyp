using System;
using System.Windows.Forms;

namespace Project_Pulse.UI.FORMS
{
    public partial class manager_main_page : Form
    {
        public manager_main_page()
        {
            InitializeComponent();

        }

        private void manager_main_page_Load(object sender, EventArgs e)
        {
            shadow_form.SetShadowForm(this);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void btn_signout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
