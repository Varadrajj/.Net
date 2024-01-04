using BOL;
using MySql.Data.MySqlClient;
namespace DAL;

public class DBManager
{
    public static string conString="server=localhost;port=3306;user=root;password=varadraj;database=varad";
    public static List<Student> GetAllStudents()
    {
        List<Student> students=new List<Student>();
        MySqlConnection connection= new MySqlConnection();
        connection.ConnectionString=conString;
        string query="select * from student1";
        MySqlCommand command=new MySqlCommand(query,connection);
        try{
            connection.Open();
            MySqlDataReader reader=command.ExecuteReader();
            while(reader.Read())
            {
                Student s=new Student();
                s.Id=int.Parse(reader["Id"].ToString());
                s.Fname=reader["Fname"].ToString();
                s.Lname=reader["Lname"].ToString();
                s.Contact=reader["Contact"].ToString();
                s.City=reader["City"].ToString();
                students.Add(s);
            }
            reader.Close();


        }catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }finally{
            connection.Close();
        }
        return students;
    }

    public static void Insert(Student s)
    {
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=conString;
        string query="insert into student1 values("+s.Id+",'"+s.Fname+"','"+s.Lname+"','"+s.Contact+"','"+s.City+"')";
        MySqlCommand command = new MySqlCommand(query,connection);
        try{
            connection.Open();
            command.ExecuteNonQuery();

        }catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }finally{
            connection.Close();
        }
    }

    public static void Delete(int id)
    {
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=conString;
        string query="delete from student1 where Id="+id+"";
        MySqlCommand command= new MySqlCommand(query,connection);
        try{
            connection.Open();
            command.ExecuteNonQuery();
        }catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }finally{
            connection.Close();
        }
    }

    public static void Update(Student s)
    {
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=conString;
        string query="update student1 set Id="+s.Id+",Fname='"+s.Fname+"',Lname='"+s.Lname+"',Contact='"+s.Contact+"',City='"+s.City+"'where Id="+s.Id+"";
        MySqlCommand command=new MySqlCommand(query,connection);
        try{
            connection.Open();
            command.ExecuteNonQuery();
        }catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }finally{
            connection.Close();
        }
    }
}

