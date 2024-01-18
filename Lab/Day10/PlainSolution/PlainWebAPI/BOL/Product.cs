namespace BOL;
public class Product
{
    public int pid { get; set; }
    public string title { get; set; }
    public string desc { get; set; }
    public int price { get; set; }
    public Product(int pid, string title, string desc, int price)
    {
        this.pid = pid;
        this.title = title;
        this.desc = desc;
        this.price = price;
    }

    public Product()
    {
    }
}