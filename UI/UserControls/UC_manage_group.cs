using Project_Pulse.DL;
using Project_Pulse.DL.CRUD_s;
using Project_Pulse.Properties;
using Project_Pulse.UI.FORMS;
using Project_Pulse.UI.UserControls.Student_;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_manage_group : UserControl
    {
        public UC_manage_group()
        {
            InitializeComponent();
        }

        private void btn_join_View_Group_Click(object sender, EventArgs e)
        {
            if (this.Parent?.Parent?.Parent?.Parent is form_manage_student form)
            {
                if (GroupCRUD.IsAlreadyGroupStudent(StudentCRUD.CurrentStudent.ID))
                {
                    form_message incorrectCredentials = new form_message("Incorrect Id", "you  typed  username  or  id:  incorrect !", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Resources.close_circle_light);
                    incorrectCredentials.Show();
                }
                else
                {

                    form.setMenu(new UC_Groups(true));
                }
            }
        }

        private void btn_Joined_groups_Click(object sender, EventArgs e)
        {
            if (this.Parent?.Parent?.Parent?.Parent is form_manage_student form)
            {
                form.setMenu(new UC_JoinedGroup());
            }
        }
    }
}
