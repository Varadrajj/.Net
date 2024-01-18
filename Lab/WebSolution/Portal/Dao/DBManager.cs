namespace dao;
using MySql.Data.MySqlClient;
using model;

public class DBManager
{
    public static string conString = @"server=192.168.10.150;port=3306;user=dac31;password=welcome;database=dac31";

    public static List<Student> getAllStudents()
    {
        List<Student> slist = new List<Student>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = conString;
        string query = "select * from student";
        MySqlCommand command = new MySqlCommand(query, connection);
        try
        {
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student std = new Student();
                std.Id = int.Parse(reader["ID"].ToString());
                std.FirstName = reader["namefirst"].ToString();
                std.LastName = reader["namelast"].ToString();
                std.EmailId = reader["emailID"].ToString();
                // std.Id = id;
                // std.FirstName = fname;
                // std.LastName = lname;
                // std.EmailId = emailid;
                slist.Add(std);
            }
            reader.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            connection.Close();
        }

        return slist;

    }
}