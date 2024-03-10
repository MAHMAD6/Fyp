using Project_Pulse.DL;
using Project_Pulse.DL.CRUD_s;
using Project_Pulse.Properties;
using Project_Pulse.UI.UserControls;
using Project_Pulse.UI.UserControls.Advisor__;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Pulse.UI.FORMS
{
    public partial class form_manage_student : Form
    {
        public form_manage_student()
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


        #region TOP BORDER BUTTONS
        private void btn_close_Click(object sender, System.EventArgs e)
        {
            Program.formToinvoke = DL.TYPE.CLOSE;
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_minimize_Click(object sender, System.EventArgs e)
        {

        }
        #endregion

        private void btn_Group_Click(object sender, System.EventArgs e)
        {
            if (ProjectCRUD.IsStudentPresentInAnyGroupProject(StudentCRUD.CurrentStudent.ID))
            {
                form_message incorrectCredentials = new form_message("Incorrect Id", "you  typed  username  or  id:  incorrect !", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Resources.close_circle_light);
                incorrectCredentials.Show();
            }
            else
            {
                setMenu(new UserControls.UC_manage_group());

            }
        }

        private void project_Click(object sender, System.EventArgs e)
        {
            if (ProjectCRUD.IsStudentPresentInAnyGroupProject(StudentCRUD.CurrentStudent.ID))
            {
                form_message incorrectCredentials = new form_message("Incorrect Id", "you  typed  username  or  id:  incorrect !", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Resources.close_circle_light);
                incorrectCredentials.Show();
            }
            else
            {
                setMenu(new UC_manage_Projects_(true));
            }
        }

        private void gunaButton1_Click(object sender, System.EventArgs e)
        {
            Program.formToinvoke = DL.TYPE.GROUP; // ENTERING ANY IRRELEVENT ENUM TO CONTINUE THE LOOP IN PROGRAM.CS
            this.Close();
        }

        private void bnt_evaluation_Click(object sender, System.EventArgs e)
        {
            setMenu(new UC_manage_Evaluation(TYPE.STUDENT));
        }
    }
}
