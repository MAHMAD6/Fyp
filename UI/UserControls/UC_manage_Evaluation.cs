using Project_Pulse.BL.Abstract;
using Project_Pulse.DL;
using Project_Pulse.DL.CRUD_s;
using Project_Pulse.UI.FORMS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_manage_Evaluation : UserControl
    {

        List<GroupEvaluation> evaluationlist = new List<GroupEvaluation>();
        int currentIndexInAdvisor_Checked = 0;
        int pageLength = 10;
        TYPE type_;
        public UC_manage_Evaluation(TYPE type)
        {
            InitializeComponent();
            type_ = type;
            if (type == TYPE.STUDENT)
            {
                btn_add.Visible = false;
            }
            else
            {
                btn_add.Visible = true;

            }
            currentIndexInAdvisor_Checked = 0;
            LoadData();
            DisplayData();
        }

        void LoadData()
        {
            if (TYPE.STUDENT == type_)
            {
                int groupId = GroupCRUD.GetGroupIdByStudentId(StudentCRUD.CurrentStudent.ID);
                try
                {
                    using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                    {
                        connection.Open();

                        // SQL query to join GroupEvaluation and Evaluation tables
                        string query = @"SELECT ge.GroupId, ge.EvaluationId, ge.ObtainedMarks, ge.EvaluationDate,
                                   e.ID, e.TotalMarks, e.TotalWeightage, e.Name
                            FROM GroupEvaluation ge
                            INNER JOIN Evaluation e ON ge.EvaluationId = e.ID
                            WHERE ge.GroupId = @GroupId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@GroupId", groupId);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Parse data and create GroupEvaluation object
                                    int obtainedMarks = reader.GetInt32(reader.GetOrdinal("ObtainedMarks"));
                                    DateTime evaluationDate = reader.GetDateTime(reader.GetOrdinal("EvaluationDate"));

                                    Evaluation evaluation = new Evaluation(
                                        reader.GetInt32(reader.GetOrdinal("ID")),
                                        reader.GetInt32(reader.GetOrdinal("TotalMarks")),
                                        reader.GetInt32(reader.GetOrdinal("TotalWeightage")),
                                        reader.GetString(reader.GetOrdinal("Name"))
                                    );

                                    GroupEvaluation groupEvaluation = new GroupEvaluation(
                                        obtainedMarks,
                                        groupId,
                                        evaluationDate,
                                        evaluation
                                    );

                                    // Add GroupEvaluation object to the global list
                                    evaluationlist.Add(groupEvaluation);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                    {
                        connection.Open();

                        // SQL query to join GroupEvaluation and Evaluation tables
                        string query = @"SELECT ge.GroupId, ge.EvaluationId, ge.ObtainedMarks, ge.EvaluationDate,
                                           e.ID, e.TotalMarks, e.TotalWeightage, e.Name
                                    FROM GroupEvaluation ge
                                    INNER JOIN Evaluation e ON ge.EvaluationId = e.ID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Parse data and create GroupEvaluation object
                                    int groupId = reader.GetInt32(reader.GetOrdinal("GroupId"));
                                    int evaluationId = reader.GetInt32(reader.GetOrdinal("EvaluationId"));
                                    int obtainedMarks = reader.GetInt32(reader.GetOrdinal("ObtainedMarks"));
                                    DateTime evaluationDate = reader.GetDateTime(reader.GetOrdinal("EvaluationDate"));

                                    Evaluation evaluation = new Evaluation(
                                        reader.GetInt32(reader.GetOrdinal("ID")),
                                        reader.GetInt32(reader.GetOrdinal("TotalMarks")),
                                        reader.GetInt32(reader.GetOrdinal("TotalWeightage")),
                                        reader.GetString(reader.GetOrdinal("Name"))
                                    );

                                    GroupEvaluation groupEvaluation = new GroupEvaluation(
                                        obtainedMarks,
                                        groupId,
                                        evaluationDate,
                                        evaluation
                                    );

                                    // Add GroupEvaluation object to the global list
                                    evaluationlist.Add(groupEvaluation);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }

        Panel loadmore;
        void DisplayData()
        {
            if (loadmore != null)
                FL_holder.Controls.Remove(loadmore);

            int count = 0;
            for (int i = currentIndexInAdvisor_Checked; count < pageLength && i < evaluationlist.Count; i++)
            {
                UC_Evaluation_Card card = new UC_Evaluation_Card(evaluationlist[i]);
                FL_holder.Controls.Add(card);
                currentIndexInAdvisor_Checked++;
                count++;
            }
            loadmore = panel_loadmore;
            loadmore.Visible = true;
            loadmore.Enabled = true;
            if (currentIndexInAdvisor_Checked == evaluationlist.Count - 1)
                FL_holder.Controls.Remove(loadmore);


            FL_holder.Controls.Add(loadmore);
        }



        private void label_heading_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            form_credentials newEvaluation = new form_credentials(DL.ACTION.EVALUATION_NEW);
            newEvaluation.Show();
        }

        private void btn_loadMore_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
        void refreshPage()
        {
            FL_holder.Controls.Clear();
            currentIndexInAdvisor_Checked = 0;
            DisplayData();
        }
    }
}
