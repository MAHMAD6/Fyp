using Project_Pulse.BL;
using Project_Pulse.BL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Pulse.DL
{
    public class AdvisorCRUD
    {
        public static Advisor CurrentAdvisor;
        public static List<GroupProject> requests = new List<GroupProject>();

        public static void DeleteProjectAdvisors(int projectId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    connection.Open();
                    // Delete project advisors associated with the project
                    string deleteProjectAdvisorQuery = "DELETE FROM ProjectAdvisor WHERE ProjectId = @ProjectId";
                    using (SqlCommand deleteProjectAdvisorCommand = new SqlCommand(deleteProjectAdvisorQuery, connection))
                    {
                        deleteProjectAdvisorCommand.Parameters.AddWithValue("@ProjectId", projectId);
                        deleteProjectAdvisorCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Project advisors deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the project advisors: " + ex.Message);
            }
        }

        public static void AddProjectAdvisor(ProjectAdvisor projectAdvisor)
        {
            string insertQuery = "INSERT INTO ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) " +
                                 "VALUES (@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate)";

            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AdvisorId", projectAdvisor.AdvisorID);
                        command.Parameters.AddWithValue("@ProjectId", projectAdvisor.ProjectID);
                        command.Parameters.AddWithValue("@AdvisorRole", projectAdvisor.AdvisorRole);
                        command.Parameters.AddWithValue("@AssignmentDate", projectAdvisor.AssignmentDate);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Project advisor added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add project advisor.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static bool isIdPresent(int id)
        {
            string query = "SELECT COUNT(*) FROM Advisor AS a " +
                           "INNER JOIN Person AS p ON a.Id = p.Id " +
                           "WHERE a.Id = @Id AND p.Gender != 4";

            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public static void UpdateAdvisor(Advisor advisor)
        {
            MessageBox.Show(advisor.ID.ToString());
            if (advisor == null) { return; }
            string query = "UPDATE Advisor SET Designation = @designation, Salary = @salary WHERE Id = @id ;";
            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", advisor.ID);
                    command.Parameters.AddWithValue("@designation", advisor.Designation);
                    command.Parameters.AddWithValue("@salary", advisor.Salary);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Advisor updated successfully");
                            // Additional validation if needed
                        }
                        else
                        {
                            // Handle if no rows were affected
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating advisor: " + ex.Message);
                    }
                }
            }
        }

        public static void AddAdvisor(Advisor advisor)
        {
            if (advisor == null) { return; }
            string query = "INSERT INTO Advisor(Id, Designation, Salary)" +
                           "VALUES(@Id, @designation, @salary);";
            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", advisor.ID);
                    command.Parameters.AddWithValue("@designation", advisor.Designation);
                    command.Parameters.AddWithValue("@salary", advisor.Salary);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Advisor added successfully");
                            // Additional validation if needed
                        }
                        else
                        {
                            // Handle if no rows were affected
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding advisor: " + ex.Message);
                    }
                }
            }
        }

        public static void DeleteAdvisor(int id)
        {
            //string deleteStudentQuery = "DELETE FROM Advisor WHERE Id = @Id";

            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            //    {
            //        connection.Open();

            //        using (SqlCommand command = new SqlCommand(deleteStudentQuery, connection))
            //        {
            //            command.Parameters.AddWithValue("@Id", id);
            //            int rowsAffected = command.ExecuteNonQuery();

            //            if (rowsAffected > 0)
            //            {
            //                MessageBox.Show("Advisor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                MessageBox.Show("Advisor with the specified ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        public static Advisor GetAdvisorByEmail(string email)
        {
            Advisor advisor = null;

            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                string sqlQuery = "SELECT a.*, p.FirstName, p.LastName, p.Contact, p.DateOfBirth, p.Gender " +
                                  "FROM Person p " +
                                  "JOIN Advisor a ON p.Id = a.Id " +
                                  "WHERE p.Email = @Email AND Gender != 4";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int advisorId = (int)reader["Id"];
                            int designation = (int)reader["Designation"];
                            decimal salary = (decimal)reader["Salary"];
                            string firstName = (string)reader["FirstName"];
                            string lastName = (string)reader["LastName"];
                            string contact = (string)reader["Contact"];
                            DateTime dateOfBirth = (DateTime)reader["DateOfBirth"];
                            int gender = (int)reader["Gender"];

                            Person person = new Person(firstName, lastName, email, contact, dateOfBirth, gender);
                            person.ID = advisorId;

                            advisor = new Advisor(designation, (float)salary, person);
                        }
                    }
                }
            }

            return advisor;
        }


    }
}
