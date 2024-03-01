using Project_Pulse.UI.UserControls.Advisor;
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

        public void setMenu(UserControl userControl)
        {
            panel_menu_container.Controls.Clear();
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;
            panel_menu_container.Controls.Add(userControl);
        }





        private void btn_signout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btn_student_Click(object sender, EventArgs e)
        {
            setMenu(new UC_manage_Students());

        }

        private void btn_close_Click_2(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_maximize_Click_2(object sender, EventArgs e)
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

        private void btn_minimize_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            setMenu(new UC_manage_Advisor());
        }
    }
}
