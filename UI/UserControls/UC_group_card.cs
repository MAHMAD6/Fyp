using Project_Pulse.BL.Abstract;
using Project_Pulse.DL;
using Project_Pulse.DL.CRUD_s;
using Project_Pulse.UI.UserControls.Student_;
using System;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_group_card : UserControl
    {
        Group _group;
        bool isLeaveGroup;
        public UC_group_card()
        {
            InitializeComponent();
        }
        public UC_group_card(Group group, ACTION action)
        {
            InitializeComponent();
            label_created_on.Text = group.Created_ON.ToString();
            label_id.Text = group.ID.ToString();
            label_members.Text = group.Students.Count.ToString();
            _group = group;
            isLeaveGroup = false;
            if (action == ACTION.GROUP_DELETE)
            {
                btn_delete.Visible = true;

            }
            else if (ACTION.GROUP_JOIN == action)
            {
                btn_join.Visible = true;

            }
            else if (ACTION.GROUP_LEAVE == action)
            {
                btn_join.Visible = true;
                isLeaveGroup = true;
                label_created_on.Text = GroupCRUD.FindGroupStudentInGroup(group, StudentCRUD.CurrentStudent.ID).AssignmentDate.ToString();
            }
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            if (isLeaveGroup)
            {
                GroupCRUD.DeleteGroupStudent(StudentCRUD.CurrentStudent.ID, _group.ID);
            }
            else
            {

                GroupCRUD.InsertStudentIntoGroup(_group.ID, StudentCRUD.CurrentStudent.ID, 3, DateTime.Now);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Parent is UC_Groups group)
            {
                GroupCRUD.DeleteGroupAndStudents(_group.ID);
                group.refresh();
                return;
            }
            if (this.Parent.Parent.Parent is UC_search_result result)
            {

                GroupCRUD.DeleteGroupAndStudents(_group.ID);

                result.backButton();
            }
        }
    }
}
