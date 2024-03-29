namespace DAL.Connected;
using BOL;
using BLL;
using MySql.Data.MySqlClient;
//using inbuilt, external Object Models
public class DBManager
{
    public static string conString = @"server=localhost;port=3306;user=root; password=welcome;database=demo";

    public static List<Product> GetAllProducts()
    {
        List<Product> list = new List<Product>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = conString;
        string query = "select * from products";
        MySqlCommand command = new MySqlCommand(query, connection);
        try
        {
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Product product = new Product();
                int id = int.Parse(reader["prod_id"].ToString());
                string title = reader["prod_title"].ToString();
                string description = reader["prod_desc"].ToString();
                int price = int.Parse(reader["prod_price"].ToString());
                product.pid = id;
                product.title = title;
                product.desc = description;
                product.price = price;
                list.Add(product);
            }
            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
        return list;
    }
}