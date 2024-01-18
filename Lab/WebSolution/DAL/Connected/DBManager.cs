namespace DAL.Connected;
using BOL;

public class DBManager
{
    public static string conString = @"server=192.168.10.150;port=3306;user=dac31;password=welcome;database=dac31";

    public static List<Student> getAllStudents()
    {
        List<Student> slist = new List<Student>();
        MySqlConnection connection = new MySqlConnection();
        connection.connectionString = conString;
        string query = "select * from student";
        MySqlCommand command = new MySqlCommand(query, connection);
        try
        {
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.read())
            {
                Student std = new Student();
                int id = int Parse.(reader["ID"]).ToString();
                string fname = reader["namefirst"].ToString();
                string lname = reader["namelast"].ToString();
                string emailid = reader["emailID"];
                std.ID = id;
                std.namefirst = fname;
                std.namelast = lname;
                std.emailID = emailid;
                slist.Add(std);
            }
            reader.close();

        }
        catch (Exception e)
        {
            Console.WriteLine("Error: "e.Message);
        }
        finally
        {
            connection.Close();
        }

        return slist;

    }
}