using Project_Pulse.BL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Pulse.DL
{
    public class StudentCRUD
    {

        public static Student CurrentStudent;
        public static void DeleteStudent(int id)
        {
            //string deleteStudentQuery = "DELETE FROM Student WHERE Id = @Id";

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
            //                MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                MessageBox.Show("Student with the specified ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        public static Student GetStudentByEmail(string email)
        {
            Student student = null;

            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                string sqlQuery = "SELECT Top 1 s.*, p.Id, p.FirstName, p.LastName, p.Contact, p.DateOfBirth, p.Gender " +
                                  "FROM Student s " +
                                  "JOIN Person p ON s.Id = p.Id " +
                                  "WHERE p.Email = @Email AND Gender != 4";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int studentId = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id"));
                            string registrationNo = reader.IsDBNull(reader.GetOrdinal("RegistrationNo")) ? string.Empty : reader.GetString(reader.GetOrdinal("RegistrationNo"));
                            string firstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? string.Empty : reader.GetString(reader.GetOrdinal("FirstName"));
                            string lastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? string.Empty : reader.GetString(reader.GetOrdinal("LastName"));
                            string contact = reader.IsDBNull(reader.GetOrdinal("Contact")) ? string.Empty : reader.GetString(reader.GetOrdinal("Contact"));
                            DateTime dateOfBirth = reader.IsDBNull(reader.GetOrdinal("DateOfBirth")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                            int gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? 0 : reader.GetInt32(reader.GetOrdinal("Gender"));

                            Person person = new Person(firstName, lastName, email, contact, dateOfBirth, gender);
                            person.ID = studentId;
                            student = new Student(registrationNo, person);
                        }
                    }
                }
            }

            return student;
        }


        public static string GenerateRollNumber(int id)
        {
            int year = DateTime.Now.Year;
            string rollNumber = $"{year}-CS-{id}";
            return rollNumber;
        }
        public static void AddStudent(Student student)
        {
            if (student == null) { return; }
            string query = "INSERT INTO Student(Id, RegistrationNo)" +
                "VALUES(@id_, @reg_no);";
            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_", student.ID);
                    command.Parameters.AddWithValue("@reg_no", student.RollNumber);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            // more validate.... (insertion successful)
                        }
                        else
                        {
                            // more validate....
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }
    }
}
