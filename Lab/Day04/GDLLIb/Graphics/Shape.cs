namespace TransFlower.Drawing;
public abstract class Shape
{
    public string color { set; get; }
    public int width { set; get; }
    public Shape()
    {
        this.color = "black";
        this.width = 0;
    }
    public Shape(string col, int wid)
    {
        this.color = col;
        this.width = wid;
    }
    public abstract void Draw();
    public override string ToString()
    {
        return "Color =" + this.color + ", Width = " + this.width;
    }
}