using Project_Pulse.BL;
using Project_Pulse.DL;
using Project_Pulse.UI.FORMS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls.Advisor
{
    public partial class UC_manage_Advisor : UserControl
    {
        private List<BL.Advisor> advisors = new List<BL.Advisor>();
        List<UC_data_tile> advisor_checked = new List<UC_data_tile>();
        int currentIndexInAdvisor_Checked = 0;
        int pageLength = 10;

        public UC_manage_Advisor()
        {
            InitializeComponent();
            LoadData();
            DisplayData();
        }
        #region not frequent
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    string sqlQuery = "SELECT p.*, a.Designation, a.Salary " +
                                      "FROM Person p " +
                                      "INNER JOIN Advisor a ON p.Id = a.Id AND p.Gender != 4";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Person person = new Person(
                                    reader["FirstName"].ToString(),
                                    reader["LastName"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Contact"].ToString(),
                                    Convert.ToDateTime(reader["DateOfBirth"]),
                                    Convert.ToInt32(reader["Gender"])
                                );
                                person.ID = Convert.ToInt32(reader["Id"]);
                                int designation = Convert.ToInt32(reader["Designation"]);
                                float salary = Convert.ToSingle(reader["Salary"]);

                                BL.Advisor advisor = new BL.Advisor(
                                    designation,
                                    salary,
                                    person
                                );

                                advisors.Add(advisor);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading advisors: " + ex.Message);
            }
        }


        Panel loadmore;
        void DisplayData()
        {
            if (loadmore != null)
                FL_holder.Controls.Remove(loadmore);

            int count = 0;
            for (int i = currentIndexInAdvisor_Checked; count < pageLength && i < advisors.Count; i++)
            {
                UC_data_tile AdvisorTile = new UC_data_tile(advisors[i]);
                AdvisorTile.SetHoverAndClickEffect(true);
                FL_holder.Controls.Add(AdvisorTile);
                currentIndexInAdvisor_Checked++;
                count++;
            }
            loadmore = panel_loadmore;
            loadmore.Visible = true;
            loadmore.Enabled = true;
            if (currentIndexInAdvisor_Checked == advisors.Count - 1)
                FL_holder.Controls.Remove(loadmore);


            FL_holder.Controls.Add(loadmore);
        }


        public void updateCheckedStudent(UC_data_tile tile)
        {
            if (tile.Checked_)
            {
                advisor_checked.Add(tile);
            }
            else
            {
                advisor_checked.Remove(tile);
            }

            if (advisor_checked.Count > 0)
            {
                top_header_CheckedState();
                if (advisor_checked.Count == 1)
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

        void top_header_CheckedState()
        {
            PB_unSelect.Visible = true;
            label_numberOf_selected_students.Visible = true;
            label_numberOf_selected_students.Text = advisor_checked.Count.ToString();
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
        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < advisor_checked.Count; i++)
            {
                AdvisorCRUD.DeleteAdvisor(advisor_checked[i].Advisor_.ID);
                PersonCRUD.DeletePerson(advisor_checked[i].Advisor_.ID);
                advisors.Remove(advisor_checked[i].Advisor_);
                advisor_checked.RemoveAt(i);
            }
            refreshPage();

        }
        void refreshPage()
        {
            FL_holder.Controls.Clear();
            top_headerTo_InitialState();
            currentIndexInAdvisor_Checked = 0;
            DisplayData();
        }

        #endregion

        private void TB_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.Parent?.Parent?.Parent?.Parent is form_manager_main_page mainPage)
                {
                    UC_search_result result = new UC_search_result(TYPE.ADVISOR, TB_search.Text.Trim(), advisors, TYPE.FIRSTNAME);
                    mainPage.setMenu(result, "Search Results");
                }
            }
        }

        private void PB_unSelect_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < advisor_checked.Count; i++)
            {
                advisor_checked[i].Checked_ = false;
                advisor_checked[i].setDefaultColor();
            }
            advisor_checked.Clear();
            top_headerTo_InitialState();
        }



        private void btn_loadMore_Click_1(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            form_credentials addAdvisor = new form_credentials(ACTION.ADD_ADVISOR);
            addAdvisor.Show();

        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            if (advisor_checked[0].Advisor_ != null)
            {

                form_credentials updateAdvisor = new form_credentials(ACTION.UPDATE_ADVISOR, advisor_checked[0].Advisor_);
                updateAdvisor.Show();

            }
        }

        private void TB_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
