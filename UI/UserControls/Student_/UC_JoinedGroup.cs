using Project_Pulse.BL.Abstract;
using Project_Pulse.DL;
using Project_Pulse.DL.CRUD_s;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls.Student_
{
    public partial class UC_JoinedGroup : UserControl
    {
        List<Group> joinedGroups = new List<Group>();
        public UC_JoinedGroup()
        {
            InitializeComponent();
            refresh();
        }
        public void refresh()
        {
            joinedGroups.Clear();
            FL_holder.Controls.Clear();
            loadData();
            DisplayData();
        }
        void loadData()
        {
            joinedGroups = GroupCRUD.GetGroupByStudentId(StudentCRUD.CurrentStudent.ID);
            foreach (Group group in joinedGroups)
            {
                group.Students = GroupCRUD.GetGroupStudents(group.ID);
            }

        }
        void DisplayData()
        {
            foreach (Group group in joinedGroups)
            {
                UC_group_card newCard = new UC_group_card(group, ACTION.GROUP_LEAVE);
                FL_holder.Controls.Add(newCard);
            }
        }
    }
}
