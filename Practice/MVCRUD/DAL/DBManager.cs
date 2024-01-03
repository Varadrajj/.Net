namespace DAL.Connected;
using MVCRUD.Models;
using MySql.Data.MySqlClient;

public class DBManager{

    public static string connString="server=localhost;port=3306;user=root;password=varadraj;database=varad";

    public static List<Product> getAllProducts()
    {
        List<Product> allProducts=new List<Product>();
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=connString;
        string query="select * from product1";
        MySqlCommand cmd=new MySqlCommand(query,connection);
        try{
            connection.Open();
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                Product p=new Product();
                p.Pid=int.Parse(reader["pid"].ToString());
                p.Pname=reader["pname"].ToString();
                p.Quantity=int.Parse(reader["qty"].ToString());
                p.Price=double.Parse(reader["price"].ToString());
                allProducts.Add(p);
            }
            reader.Close();


        }catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }finally{
            connection.Close();
        }
        return allProducts;


    }


    public static void Insert(Product p)
    {
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=connString;
        string query="insert into product1 values("+p.Pid+",'"+p.Pname+"',"+p.Quantity+","+p.Price+")";
        MySqlCommand command=new MySqlCommand(query,connection);
        try{
            connection.Open();
            command.ExecuteNonQuery();

        }catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }
        finally{
            connection.Close();
        }
    }

    public static void Delete(int id)
    {
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=connString;
        string query="delete from product1 where pid="+id+"";
        MySqlCommand command=new MySqlCommand(query,connection);
        try{
            connection.Open();
            command.ExecuteNonQuery();
        }catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }
        finally{
            connection.Close();
        }
    }


    public static void Update(Product product)
    {
        MySqlConnection connection= new MySqlConnection();
        connection.ConnectionString=connString;
        string query="update product1 set pid="+product.Pid+",pname='"+product.Pname+"',qty="+product.Quantity+",price="+product.Price+" where pid="+product.Pid+"";
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


}
