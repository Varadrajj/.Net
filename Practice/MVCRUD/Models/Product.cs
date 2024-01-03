namespace MVCRUD.Models;

public class Product{
    public int Pid{set; get;}
    public string Pname{set; get;}
    public int Quantity{set; get;}
    public double Price{set; get;}

    public Product(){

    }

    public Product(int id, string pname, int qty, double price){
        this.Pid=id;
        this.Pname=pname;
        this.Quantity=qty;
        this.Price=price;
    }
}