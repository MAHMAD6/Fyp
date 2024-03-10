using Project_Pulse.BL.Abstract;
using Project_Pulse.DL;
using Project_Pulse.DL.CRUD_s;
using Project_Pulse.UI.FORMS;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls.Student_
{
    public partial class UC_Groups : UserControl
    {
        List<Group> groups = new List<Group>();
        public UC_Groups()
        {
            InitializeComponent();
            isJoin = false;
            loadData();
            DisplayData();
        }
        bool isJoin;
        public UC_Groups(bool isJoinMenu)
        {
            InitializeComponent();
            isJoin = isJoinMenu;
            if (isJoin)
            {
                btn_add.Visible = false;
            }
            loadData();
            DisplayData();
        }
        void loadData()
        {
            groups = GroupCRUD.CreateObjectsFromGroupTable();
            for (int i = 0; i < groups.Count; i++)
            {
                groups[i].Students = GroupCRUD.GetGroupStudents(groups[i].ID);
            }
        }
        void DisplayData()
        {
            foreach (Group group in groups)
            {
                UC_group_card newCard;
                if (isJoin)
                {

                    newCard = new UC_group_card(group, ACTION.GROUP_JOIN);
                }
                else
                {
                    newCard = new UC_group_card(group, ACTION.GROUP_DELETE);

                }
                FL_holder.Controls.Add(newCard);
            }
        }
        private void btn_add_Click(object sender, System.EventArgs e)
        {
            GroupCRUD.InsertNewGroup();
            refresh();
        }

        public void refresh()
        {
            groups.Clear();
            FL_holder.Controls.Clear();
            loadData();
            DisplayData();
        }

        private void TB_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.Parent?.Parent?.Parent?.Parent is form_manage_student studentMainPage)
                {

                    UC_search_result result = new UC_search_result(TYPE.JOINGROUP, TB_search.Text.Trim(), groups, TYPE.ID);
                    studentMainPage.setMenu(result);

                }

                else if (this.Parent?.Parent?.Parent?.Parent is form_manager_main_page mainPage)
                {

                    UC_search_result result = new UC_search_result(TYPE.GROUP, TB_search.Text.Trim(), groups, TYPE.ID);
                    mainPage.setMenu(result, "Search Results");
                }
            }
        }
    }
}
