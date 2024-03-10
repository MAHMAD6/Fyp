using Project_Pulse.BL.Abstract;
using Project_Pulse.DL;
using Project_Pulse.DL.CRUD_s;
using Project_Pulse.UI.FORMS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls.Advisor__
{
    public partial class UC_manage_Projects_ : UserControl
    {
        private List<Project> projects = new List<Project>();
        private List<UC_project_card> Checked_projects = new List<UC_project_card>();
        int currentIndexInProject_Checked = 0;
        int pageLength = 10;
        Panel loadmore;
        bool isStudent_;
        public UC_manage_Projects_(bool isStudent)
        {
            InitializeComponent();
            isStudent_ = isStudent;
            btn_add.Visible = false;
            loadData();
            DisplayData();
        }

        public UC_manage_Projects_()
        {
            InitializeComponent();
            refresh();
        }

        void loadData()
        {
            projects = ProjectCRUD.GetProjects();
        }
        void DisplayData()
        {
            if (loadmore != null)
                FL_holder.Controls.Remove(loadmore);

            int count = 0;
            for (int i = currentIndexInProject_Checked; count < pageLength && i < projects.Count; i++)
            {
                UC_project_card uC_Project_Card = new UC_project_card(projects[i], true);
                if (!isStudent_)
                    uC_Project_Card.setHoverEffectAndClick();
                FL_holder.Controls.Add(uC_Project_Card);
                currentIndexInProject_Checked++;
                count++;
            }
            loadmore = panel_loadmore;
            loadmore.Visible = true;
            loadmore.Enabled = true;
            if (currentIndexInProject_Checked == projects.Count - 1)
                FL_holder.Controls.Remove(loadmore);


            FL_holder.Controls.Add(loadmore);
        }

        public void refresh()
        {
            projects.Clear();
            loadData();
            DisplayData();
        }

        public void updateCheckedProjects(UC_project_card card)
        {
            if (!isStudent_)
            {

                if (card.checked_)
                {
                    Checked_projects.Add(card);
                }
                else
                {
                    Checked_projects.Remove(card);

                }
                if (Checked_projects.Count > 0)
                {
                    top_header_CheckedState();
                    if (Checked_projects.Count == 1)
                    {

                        btn_update.Visible = true;
                    }
                    else
                    {

                        btn_update.Visible = false;
                    }

                }
                else
                {
                    top_headerTo_InitialState();
                }
            }
        }

        void top_header_CheckedState()
        {
            PB_unSelect.Visible = true;
            label_numberOf_selected_students.Visible = true;
            label_numberOf_selected_students.Text = Checked_projects.Count.ToString();
            label_Selected.Visible = true;
            label_heading.Visible = false;
            btn_delete.Visible = true;
            TB_search.Visible = false;
            btn_add.Visible = false;
        }

        void top_headerTo_InitialState()
        {
            PB_unSelect.Visible = false;
            label_numberOf_selected_students.Visible = false;
            label_numberOf_selected_students.Text = "0";
            label_Selected.Visible = false;
            label_heading.Visible = true;
            btn_delete.Visible = false;
            TB_search.Visible = true;
            btn_add.Visible = true;
            btn_update.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            form_credentials addProject = new form_credentials(ACTION.PROJECT_ADD);
            addProject.Show();
        }

        private void PB_unSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Checked_projects.Count; i++)
            {
                Checked_projects[i].checked_ = false;
                Checked_projects[i].setDefaultColor();
            }
            Checked_projects.Clear();
            top_headerTo_InitialState();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = Checked_projects.Count - 1;
            while (i >= 0)
            {
                AdvisorCRUD.DeleteProjectAdvisors(Checked_projects[i].project_.ID);
                ProjectCRUD.DeleteProject(Checked_projects[i].project_.ID);
                projects.Remove(Checked_projects[i].project_);
                Checked_projects.RemoveAt(i);
                i--;
            }
            refresh();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (Checked_projects[0] != null)
            {
                form_credentials updateProject = new form_credentials(Checked_projects[0].project_);
                updateProject.Show();
            }
        }

        private void TB_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (this.Parent?.Parent?.Parent?.Parent is form_manage_student mainPage)
                //{
                //    UC_search_result result = new UC_search_result(TYPE.ADVISOR, TB_search.Text.Trim(), advisors, TYPE.FIRSTNAME);
                //    mainPage.setMenu(result);
                //}
            }
        }
    }
}
