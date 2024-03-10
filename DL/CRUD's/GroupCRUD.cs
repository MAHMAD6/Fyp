using Project_Pulse.BL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Pulse.DL.CRUD_s
{
    public class GroupCRUD
    {

        public static int GetGroupIdByStudentId(int studentId)
        {
            int groupId = -1; // Default value if no group is found

            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    connection.Open();

                    string query = "SELECT GroupID FROM GroupStudent WHERE StudentID = @StudentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            groupId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving group ID: " + ex.Message);
            }

            return groupId;
        }

        public static bool IsAlreadyGroupStudent(int studentId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM GroupStudent WHERE StudentId = @StudentId";
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
                MessageBox.Show("An error occurred while checking if the student is already in a group: " + ex.Message);
                return false;
            }
        }

        public static void AddGroupProject(int groupId, int projectId, DateTime assignmentDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    string query = "INSERT INTO GroupProject (GroupID, ProjectID, AssignmentDate) VALUES (@GroupID, @ProjectID, @AssignmentDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GroupID", groupId);
                        command.Parameters.AddWithValue("@ProjectID", projectId);
                        command.Parameters.AddWithValue("@AssignmentDate", assignmentDate);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding entry to GroupProject table: " + ex.Message);
            }
        }
        public static GroupStudent FindGroupStudentInGroup(Group group, int StudentID)
        {
            foreach (GroupStudent groupStudent in group.Students)
            {
                if (StudentID == groupStudent.StudentId)
                {
                    return groupStudent;
                }
            }
            return null;
        }
        public static void DeleteGroupStudent(int studentId, int groupId)
        {
            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                string query = "DELETE FROM GroupStudent WHERE StudentId = @StudentId AND GroupId =@GroupId_";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@GroupId_", groupId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static List<Group> GetGroupByStudentId(int studentId)
        {
            List<Group> groups = new List<Group>();

            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                string query = @"
            SELECT g.ID, g.Created_On
            FROM [Group] g
            INNER JOIN GroupStudent gs ON g.ID = gs.GroupId
            WHERE gs.StudentId = @StudentId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Group group = new Group(Convert.ToInt32(reader["ID"]), Convert.ToDateTime(reader["Created_On"]));
                    groups.Add(group);
                }

                reader.Close();
            }

            return groups;
        }

        public static void InsertStudentIntoGroup(int groupId, int studentId, int status, DateTime assignmentDate)
        {
            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                string query = "INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) VALUES (@GroupId, @StudentId, @Status, @AssignmentDate)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@GroupId", groupId);
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@AssignmentDate", assignmentDate);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Student inserted into GroupStudent table successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        public static void DeleteGroupAndStudents(int groupId)
        {
            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Delete students from GroupStudent table
                    string deleteStudentsQuery = "DELETE FROM GroupStudent WHERE GroupId = @GroupId";
                    SqlCommand deleteStudentsCommand = new SqlCommand(deleteStudentsQuery, connection, transaction);
                    deleteStudentsCommand.Parameters.AddWithValue("@GroupId", groupId);
                    deleteStudentsCommand.ExecuteNonQuery();

                    // Delete group from Group table
                    string deleteGroupQuery = "DELETE FROM [Group] WHERE Id = @GroupId";
                    SqlCommand deleteGroupCommand = new SqlCommand(deleteGroupQuery, connection, transaction);
                    deleteGroupCommand.Parameters.AddWithValue("@GroupId", groupId);
                    deleteGroupCommand.ExecuteNonQuery();

                    transaction.Commit();
                    Console.WriteLine("Group and its corresponding students deleted successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        public static List<Group> CreateObjectsFromGroupTable()
        {
            List<Group> groups = new List<Group>();

            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                string query = "SELECT ID, Created_On FROM [Group]";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    DateTime createdOn = reader.GetDateTime(1);

                    Group group = new Group(id, createdOn);
                    groups.Add(group);
                }

                reader.Close();
            }

            return groups;
        }
        public static List<GroupStudent> GetGroupStudents(int groupId)
        {
            List<GroupStudent> groupStudents = new List<GroupStudent>();

            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                string query = "SELECT GroupId, StudentId, Status, AssignmentDate FROM GroupStudent WHERE GroupId = @GroupId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GroupId", groupId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    GroupStudent groupStudent = new GroupStudent
                    {
                        GroupId = Convert.ToInt32(reader["GroupId"]),
                        StudentId = Convert.ToInt32(reader["StudentId"]),
                        Status = Convert.ToInt32(reader["Status"]),
                        AssignmentDate = Convert.ToDateTime(reader["AssignmentDate"])
                    };

                    groupStudents.Add(groupStudent);
                }

                reader.Close();
            }

            return groupStudents;
        }
        public static void InsertNewGroup()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    string sqlQuery = "INSERT INTO [Group] (Created_On) VALUES (@CreatedOn)";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CreatedOn", DateTime.Now);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New group inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert new group.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting new group: " + ex.Message);
            }
        }
    }
}
