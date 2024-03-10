using Project_Pulse.DL;
using Project_Pulse.UI.UserControls;
using Project_Pulse.UI.UserControls.Advisor;
using Project_Pulse.UI.UserControls.Advisor__;
using Project_Pulse.UI.UserControls.Student_;
using System;
using System.Windows.Forms;

namespace Project_Pulse.UI.FORMS
{
    public partial class form_manager_main_page : Form
    {
        public form_manager_main_page()
        {
            InitializeComponent();
            //label_current_user_Designation.Text = Essentials.LookupToString(AdvisorCRUD.CurrentAdvisor.Designation);
            //label_current_user_name.Text = AdvisorCRUD.CurrentAdvisor.FirstName;
        }

        public void setMenu(UserControl userControl, string menuTitle)
        {
            label_menu_title.Text = menuTitle;
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
            setMenu(new UC_manage_Students(), "Manage Students");

        }
        #region TOP BORDER BUTTONS
        private void btn_close_Click_2(object sender, EventArgs e)
        {
            Essentials.CloseApplication();

        }


        private void btn_maximize_Click_2(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                panel3.Size = new System.Drawing.Size(263, 709);
                panel11.Size = new System.Drawing.Size(350, 56);
            }
            else
            {
                panel11.Size = new System.Drawing.Size(119, 46);
                panel3.Size = new System.Drawing.Size(263, 509);
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_minimize_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        #endregion





        private void gunaButton2_Click(object sender, EventArgs e)
        {
            setMenu(new UC_manage_Advisor(), "Manage Advisors");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_group_Click(object sender, EventArgs e)
        {
            setMenu(new UC_Groups(), "Manage Groups");
        }

        private void btn_project_Click(object sender, EventArgs e)
        {
            setMenu(new UC_manage_Projects_(), "Manage Projects");
        }

        private void btn_requests_Click(object sender, EventArgs e)
        {
            //AdvisorCRUD.requests.Add(new BL.Abstract.GroupProject(6, 26, DateTime.Now));
            setMenu(new UC_requests(), "Requests");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Program.formToinvoke = TYPE.LASTNAME;
            this.Close();
        }

        private void btn_evaluation_Click(object sender, EventArgs e)
        {
            setMenu(new UC_manage_Evaluation(TYPE.ADVISOR), "Manage Evaluation");
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            setMenu(new UC_manage_Report(), "Reports");
        }
    }
}
