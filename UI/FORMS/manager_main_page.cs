using System;
using System.Windows.Forms;

namespace Project_Pulse.UI.FORMS
{
    public partial class form_manager_main_page : Form
    {
        public form_manager_main_page()
        {
            InitializeComponent();

        }



        private void manager_main_page_Load(object sender, EventArgs e)
        {
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

        private void btn_maximize_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                panel3.Size = new System.Drawing.Size(263, 709);

            }
            else
            {
                panel3.Size = new System.Drawing.Size(263, 509);
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
