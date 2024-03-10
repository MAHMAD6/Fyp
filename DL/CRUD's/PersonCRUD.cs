using Project_Pulse.BL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Pulse.DL
{
    public class PersonCRUD
    {

        public static void UpdatePerson(Person person)
        {
            if (person == null) { return; }

            string query = "UPDATE Person SET FirstName = @first_name, LastName = @last_name, Contact = @contact_, Email = @email_, " +
                           "DateOfBirth = @date_of_birth, Gender = @gender_ WHERE Id = @id AND Gender != 4;";
            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", person.ID);
                    command.Parameters.AddWithValue("@first_name", person.FirstName);
                    command.Parameters.AddWithValue("@last_name", person.LastName);
                    command.Parameters.AddWithValue("@contact_", person.Contact);
                    command.Parameters.AddWithValue("@email_", person.Email);
                    command.Parameters.AddWithValue("@date_of_birth", person.Birthday);
                    command.Parameters.AddWithValue("@gender_", person.Gender);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Person updated successfully");
                            // more validation....
                        }
                        else
                        {
                            MessageBox.Show("Person update failed" + person.ToString__());
                            // more validation....
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + "  >>>>>>> Person update failed");
                    }
                }
            }
        }

        public static void DeletePerson(int id)
        {
            string updatePersonQuery = "UPDATE Person SET Gender = 4 WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updatePersonQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Person removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Person with the specified ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }










        public static void AddPerson(Person person)
        {
            if (person == null) { return; }
            string query = "INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender)" +
                "VALUES(@first_name,@last_name,@contact_,@email_,@date_of_birth,@gender_);";
            using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@first_name", person.FirstName);
                    command.Parameters.AddWithValue("@last_name", person.LastName);
                    command.Parameters.AddWithValue("@contact_", person.Contact);
                    command.Parameters.AddWithValue("@email_", person.Email);
                    command.Parameters.AddWithValue("@date_of_birth", person.Birthday);
                    command.Parameters.AddWithValue("@gender_", person.Gender);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // more validate....
                        }
                        else
                        {
                            MessageBox.Show("person added fail");
                            // more validate....
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + "  >>>>>>> person added");
                    }
                }
            }
        }
        public static bool isAlreadyPresent_Email(string email)
        {
            string query = "SELECT FirstName FROM Person WHERE Email = @mail;";
            using (SqlConnection conn = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mail", email);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("already Presen");
                            return true;
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            return false;
        }
        public static int getHighestID()
        {
            string query = "SELECT MAX(Id) AS max_id FROM Person WHERE Gender != 4;";
            using (SqlConnection conn = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            object maxId = reader["max_id"]; // Access the result using the alias "max_id"
                            if (maxId != DBNull.Value)
                            {
                                return (int)maxId;
                            }
                            else
                            {
                                MessageBox.Show("No records found in the Person table.");
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }

            return -1;
        }
        public static int GetId(string firstName, string lastName, string email)
        {
            string query = "SELECT TOP 1 Id FROM Person WHERE FirstName = @name AND LastName = @last_name AND Email = @email AND Gender != 4;";
            using (SqlConnection conn = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", firstName);
                    cmd.Parameters.AddWithValue("@last_name", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int id = Convert.ToInt32(result);
                            return id;
                        }
                        else
                        {
                            MessageBox.Show("No record found.");
                            return -1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " >>>>>getid");
                        return -1;
                    }
                }
            }
        }
        public static int GetId(string email)
        {
            string query = "SELECT TOP 1 Id FROM Person WHERE Email = @email AND Gender != 4;";
            using (SqlConnection conn = new SqlConnection(Essentials.SqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int id = Convert.ToInt32(result);
                            MessageBox.Show(id.ToString() + " getid");
                            return id;
                        }
                        else
                        {
                            MessageBox.Show("No record found.");
                            return -1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " >>>>>getid");
                        return -1;
                    }
                }
            }
        }

    }
}
