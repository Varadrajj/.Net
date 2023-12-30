namespace Catalog;

public class Product
{
    public int Id { set; get; }
    public string Title { set; get; }
    public string Description { set; get; }
    public double UnitPrice { set; get; }

    public Product()
    {
        this.Id = 1;
        this.Title = "Gerbera";
        this.Description = "Smelling Flower";
        this.UnitPrice = 50;
    }

    public Product(int id, string title, string description, double unitprice)
    {
        this.Id = id;
        this.Title = title;
        this.Description = description;
        this.UnitPrice = unitprice;
    }

    public override string ToString()
    {
        return this.Id + " " + this.Title + " " + this.Description + " " + this.UnitPrice;
    }

}
