
namespace Drawing;

public abstract class Shape
{
    public Shape()
    {
        this.Color = "black";
        this.Width = 0;
    }

    public Shape(int w, string c)
    {
        this.Color = c;
        this.Width = w;
    }

    public int Width
    {
        set; get;
    }

    public string Color
    {
        set; get;
    }

    public abstract void Draw();

    public override string ToString()
    {
        return "Width= " + this.Width + " Color=" + this.Color;
    }
}