using Project_Pulse.BL;
using Project_Pulse.BL.Abstract;
using Project_Pulse.DL;
using Project_Pulse.UI.FORMS;
using Project_Pulse.UI.UserControls.Advisor;
using Project_Pulse.UI.UserControls.Student_;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_search_result : UserControl
    {
        TYPE type_;
        public UC_search_result()
        {
            InitializeComponent();
        }

        public UC_search_result(TYPE type, string text_to_search, List<Project> projects, TYPE search_by)
        {
            InitializeComponent();
            type_ = type;
            if (type == TYPE.PROJECT)
            {
                if (search_by == TYPE.ID)
                {
                    projectIDsearch(projects, text_to_search);
                }
            }
        }

        void projectIDsearch(List<Project> projects, string id)
        {
            for (int i = 0; i < projects.Count; i++)
            {
                if (projects[i].ID == int.Parse(id))
                {
                    if (TYPE.PROJECT == type_)
                    {
                        FL_holder.Controls.Add(new UC_project_card(projects[i]));
                    }
                }
            }
        }

        #region SERACH GROUP
        public UC_search_result(TYPE type, string text_to_search, List<Group> groups, TYPE search_by)
        {
            InitializeComponent();
            type_ = type;
            if (type == TYPE.GROUP || type_ == TYPE.JOINGROUP)
            {
                if (search_by == TYPE.ID)
                {
                    groupIdSearch(groups, text_to_search);
                }
            }
        }
        private void groupIdSearch(List<Group> groups, string id)
        {
            for (int i = 0; i < groups.Count; i++)
            {
                if (groups[i].ID == int.Parse(id))
                {
                    UC_group_card newCard = null;
                    if (type_ == TYPE.GROUP)
                    {
                        newCard = new UC_group_card(groups[i], ACTION.GROUP_DELETE);

                    }
                    else if (type_ == TYPE.JOINGROUP)
                    {
                        newCard = new UC_group_card(groups[i], ACTION.GROUP_JOIN);
                    }
                    FL_holder.Controls.Add(newCard);
                }
            }
        }
        #endregion


        #region SEARCH STUDENT
        public UC_search_result(TYPE type, string text_to_search, List<Student> students, TYPE search_by)
        {
            InitializeComponent();
            type_ = type;
            if (type == TYPE.STUDENT)
            {
                if (search_by == TYPE.FIRSTNAME)
                {
                    firstNameSearch(students, text_to_search);
                }
            }
        }
        void firstNameSearch(List<BL.Student> students, string firstName)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (firstName == students[i].FirstName)
                {
                    UC_data_tile newCard = new UC_data_tile(students[i]);
                    FL_holder.Controls.Add(newCard);
                }
            }
        }
        #endregion



        #region SEARCH ADVISOR
        public UC_search_result(TYPE type, string text_to_search, List<BL.Advisor> advisors, TYPE search_by)
        {
            InitializeComponent();
            type_ = type;

            if (type == TYPE.ADVISOR)
            {
                if (search_by == TYPE.FIRSTNAME)
                {
                    firstNameSearch(advisors, text_to_search);
                }
            }
        }
        void firstNameSearch(List<BL.Advisor> advisors, string firstName)
        {
            for (int i = 0; i < advisors.Count; i++)
            {
                if (firstName == advisors[i].FirstName)
                {
                    UC_data_tile newCard = new UC_data_tile(advisors[i]);
                    FL_holder.Controls.Add(newCard);
                }
            }
        }
        #endregion




        // BACK BUTTON CLICKED
        private void btn_back_Click(object sender, EventArgs e)
        {
            backButton();
        }
        public void backButton()
        {
            if (this.Parent?.Parent?.Parent?.Parent is form_manage_student StudentMainPage)
            {
                if (type_ == TYPE.JOINGROUP)
                {

                    StudentMainPage.setMenu(new UC_manage_group());
                }
            }
            else if (this.Parent?.Parent?.Parent?.Parent is form_manager_main_page mainpage)
            {
                if (type_ == TYPE.GROUP)
                {
                    UC_Groups uC_Groups = new UC_Groups();
                    mainpage.setMenu(uC_Groups, "Manage Groups");
                }
                else if (type_ == TYPE.ADVISOR)
                {
                    UC_manage_Advisor newManageStudents = new UC_manage_Advisor();
                    mainpage.setMenu(newManageStudents, "Manage Advisors");
                }
                else if (type_ == TYPE.STUDENT)
                {
                    UC_manage_Students uC_Manage_Students = new UC_manage_Students();
                    mainpage.setMenu(uC_Manage_Students, "Manage Students");
                }
            }
        }
    }
}
