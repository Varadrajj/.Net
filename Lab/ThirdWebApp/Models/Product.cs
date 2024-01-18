namespace Catalogue;

public class Product
{
    public int Id { set; get; }
    public string Title { set; get; }
    public string Description { set; get; }
    public float UnitPrice { set; get; }
    public int Quantity { set; get; }
    public string ImgUrl { set; get; }

    public Product()
    {
        this.Id = 01;
        this.Title = "Jasmine";
        this.Description = "Fragrance Flower";
        this.UnitPrice = 10;
        this.Quantity = 10;
        this.ImgUrl = "";
    }
}