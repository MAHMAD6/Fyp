using Project_Pulse.BL.Abstract;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Pulse.DL.CRUD_s
{
    public class EvaluationCRUD
    {
        public static void InsertEvaluation(Evaluation evaluation)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Evaluation (Name, TotalMarks, TotalWeightage)
                             VALUES (@Name, @TotalMarks, @TotalWeightage);
                             SELECT SCOPE_IDENTITY();"; // Retrieve the ID of the inserted row

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", evaluation.Name);
                        command.Parameters.AddWithValue("@TotalMarks", evaluation.TotalMarks);
                        command.Parameters.AddWithValue("@TotalWeightage", evaluation.TotalWeightage);

                        // Execute the query and retrieve the inserted ID
                        int evaluationId = Convert.ToInt32(command.ExecuteScalar());

                        // Assign the retrieved ID to the Evaluation object
                        evaluation.ID = evaluationId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting evaluation: " + ex.Message);
            }
        }

        public static int GetEvaluationID(string name)
        {
            int evaluationId = -1; // Default value if not found

            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id FROM Evaluation WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);

                        // Execute the query and retrieve the evaluation ID
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            evaluationId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while getting evaluation ID: " + ex.Message);
            }

            return evaluationId;
        }

        public static void InsertGroupEvaluation(int GroupId, int EvaluationId, int ObtainedMarks, DateTime evaluationDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate)
                             VALUES (@GroupId, @EvaluationId, @ObtainedMarks, @EvaluationDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GroupId", GroupId);
                        command.Parameters.AddWithValue("@EvaluationId", EvaluationId);
                        command.Parameters.AddWithValue("@ObtainedMarks", ObtainedMarks);
                        command.Parameters.AddWithValue("@EvaluationDate", evaluationDate);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting group evaluation: " + ex.Message);
            }
        }
    }
}
