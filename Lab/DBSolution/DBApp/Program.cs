using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to Database App");

//Define Connection String
//Create connection object
MySqlConnection connection = new MySqlConnection();

//Set connection string to connection object
connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac31;password=welcome;database=dac31";

//Define Sql query

//.ExecuterReader
string query = "select * from emp";

//DML Operations
//.ExecuteNonQuery
// string query="delete from softdrink where id=5";
// string query = "insert into softdrink values(5,'Iced Tea',50)";
// string query = "update softdrink set name='Coffee' where id=5";

// Console.WriteLine("Enter id of the product to be deleted= ");
// int id = int.Parse(Console.ReadLine());
// string query = "delete from softdrink where id=@id";

// Console.WriteLine("Enter id= ");
// int id = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the Name of product= ");
// string name = Console.ReadLine();
// Console.WriteLine("Enter the rate of product= ");
// int rate = int.Parse(Console.ReadLine());

// string query = "insert into softdrink values(@id,@name,@rate)";


//Aggregate Operations
//.ExecuteScaler

// string query = "select count(*) from softdrink";


//Create command object
MySqlCommand command = new MySqlCommand(query, connection);


// command.Parameters.AddWithValue("@id", id);
// command.Parameters.AddWithValue("@name", name);
// command.Parameters.AddWithValue("@rate", rate);


try
{
    //Open connection
    connection.Open();
    // Execute Command
    MySqlDataReader reader = command.ExecuteReader();
    //Iterate data from reader object
    while (reader.Read())
    {
        int id = int.Parse(reader["empno"].ToString());
        string name = reader["ename"].ToString();
        string job = reader["job"].ToString();
        int sal = int.Parse(reader["sal"].ToString());
        DateTime d = Convert.ToDateTime(reader["hiredate"]);
        // string d = reader["hiredate"].ToString();
        //Show Data
        Console.WriteLine(id + " " + name + " " + job + " " + sal + "   " + d);
    }
    reader.Close();

    //For DML operations(Delete,Insert,Update)
    // command.ExecuteNonQuery();

    //     //For Aggregate Operations(count)
    //     int count = int.Parse((command.ExecuteScalar()).ToString());
    //     Console.WriteLine("Number of products avaible is= " + count);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);

}
finally
{
    //Close Connection
    connection.Close();
}