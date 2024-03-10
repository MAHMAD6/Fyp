using Project_Pulse.BL;
using Project_Pulse.DL;
using Project_Pulse.UI.FORMS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls.Advisor
{
    public partial class UC_manage_Students : UserControl
    {
        private List<Student> students = new List<Student>();
        List<UC_data_tile> students_checked = new List<UC_data_tile>();
        int currentIndexInStudentLoaded = 0;
        int pageLength = 10;
        public UC_manage_Students()
        {
            InitializeComponent();
            LoadData();
            DisplayData();
        }
        private void LoadData()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    string sqlQuery = "SELECT p.*, s.RegistrationNo " +
                                      "FROM Person p " +
                                      "INNER JOIN Student s ON p.Id = s.Id AND p.Gender != 4";

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
                                Student student = new Student(
                                    reader["RegistrationNo"].ToString(),
                                    person
                                );

                                students.Add(student);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }

        }

        Panel loadmore;
        void DisplayData()
        {
            if (loadmore != null)
                FL_students_holder.Controls.Remove(loadmore);

            int count = 0;
            for (int i = currentIndexInStudentLoaded; count < pageLength && i < students.Count; i++)
            {
                UC_data_tile uC_Student_TILE = new UC_data_tile(students[i]);
                uC_Student_TILE.SetHoverAndClickEffect(true);
                FL_students_holder.Controls.Add(uC_Student_TILE);
                currentIndexInStudentLoaded++;
                count++;
            }
            loadmore = panel_loadmore;
            loadmore.Visible = true;
            loadmore.Enabled = true;
            if (currentIndexInStudentLoaded == students.Count - 1)
                FL_students_holder.Controls.Remove(loadmore);


            FL_students_holder.Controls.Add(loadmore);
        }
        private void btn_loadMore_Click(object sender, EventArgs e)
        {

            DisplayData();
        }

        public void updateCheckedStudent(UC_data_tile tile)
        {
            if (tile.Checked_)
            {
                students_checked.Add(tile);
            }
            else
            {
                students_checked.Remove(tile);
            }
            if (students_checked.Count > 0)
            {
                PB_unSelect.Visible = true;
                label_numberOf_selected_students.Visible = true;
                label_numberOf_selected_students.Text = students_checked.Count.ToString();
                label_Selected.Visible = true;
                label_heading_double_click.Visible = false;
                btn_delete.Visible = true;
                TB_search_student.Visible = false;

            }
            else
            {
                top_headerTo_InitialState();
            }
        }



        private void PB_unSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < students_checked.Count; i++)
            {
                students_checked[i].Checked_ = false;
                students_checked[i].setDefaultColor();
            }
            students_checked.Clear();
            top_headerTo_InitialState();
        }
        void top_headerTo_InitialState()
        {
            PB_unSelect.Visible = false;
            label_numberOf_selected_students.Visible = false;
            label_numberOf_selected_students.Text = "0";
            label_Selected.Visible = false;
            label_heading_double_click.Visible = true;
            btn_delete.Visible = false;
            TB_search_student.Visible = true;

        }

        private void TB_search_student_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.Parent.Parent.Parent.Parent is form_manager_main_page mainPage)
                {
                    UC_search_result result = new UC_search_result(TYPE.STUDENT, TB_search_student.Text.Trim(), students, TYPE.FIRSTNAME);
                    mainPage.setMenu(result, "Search");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < students_checked.Count; i++)
            {
                StudentCRUD.DeleteStudent(students_checked[i].Student_.ID);
                PersonCRUD.DeletePerson(students_checked[i].Student_.ID);
                students.Remove(students_checked[i].Student_);
                students_checked.RemoveAt(i);
            }
            FL_students_holder.Controls.Clear();
            top_headerTo_InitialState();
            currentIndexInStudentLoaded = 0;
            DisplayData();
        }
    }
}
