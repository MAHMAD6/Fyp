using Project_Pulse.BL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Pulse.DL.CRUD_s
{
    public class ProjectCRUD
    {

        public static bool IsGroupPresentInGroupProject(int groupId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM GroupProject WHERE GroupId = @GroupId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GroupId", groupId);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking if the group is present in GroupProject table: " + ex.Message);
                return false;
            }
        }

        public static bool IsStudentPresentInAnyGroupProject(int studentId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM GroupProject WHERE ProjectId IN (SELECT ProjectId FROM GroupStudent WHERE StudentId = @StudentId)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking if the student is present in any group project: " + ex.Message);
                return false;
            }
        }

        public static int GetID(string title)
        {
            string query = "SELECT TOP 1 Id FROM Project WHERE Title = @title_;";
            using (SqlConnection conn = new SqlConnection(Essentials.SqlConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title_", title);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public static void UpdateProject(int projectId, string title, string description)
        {
            // SQL query to update data in the Project table
            string query = "UPDATE Project SET Title = @Title, Description = @Description WHERE Id = @Id";

            // Create SqlConnection and SqlCommand objects
            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Id", projectId);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Project updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No rows affected. Project not updated.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
        }

        public static void DeleteProject(int projectId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    string query = "DELETE FROM Project WHERE Id = @ProjectId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProjectId", projectId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the project: " + ex.Message);
            }
        }
        public static List<Project> GetProjects()
        {
            List<Project> projects = new List<Project>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    string sqlQuery = "SELECT Id, Title, Description FROM Project";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["Id"]);
                                string title = reader["Title"].ToString();
                                string description = reader["Description"].ToString();

                                Project project = new Project(id, title, description);
                                projects.Add(project);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading projects: " + ex.Message);
            }

            return projects;
        }


        public static void AddProject(string title, string description)
        {

            // SQL query to insert data into the Project table
            string query = "INSERT INTO Project (Title, Description) VALUES (@Title, @Description)";

            // Create SqlConnection and SqlCommand objects
            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Project added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No rows affected. Project not added.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
        }


    }
}
