namespace BLL;
using BOL;
using DAL.Connected;
public class Cataloguemanager
{
    public List<Product> GetAllProducts()
    {
        List<Product> allproducts = new List<Product>();
        allproducts = DBManager.GetAllProducts();
        return allproducts;
    }
    public Product GetProduct(int id)
    {
        List<Product> allproducts = GetAllProducts();
        Product product = allproducts.Find((product) => product.pid == id);
        return product;
    }
}