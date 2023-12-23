using Hardware;
namespace Drawing;

public class Line : Shape, IPrinter
{
    public Point StartPoint { set; get; }
    public Point EndPoint { set; get; }

    public Line() : base()
    {
        this.StartPoint = new Point(0, 0);
        this.EndPoint = new Point(0, 0);
    }

    public Line(int w, string c, Point p1, Point p2) : base(w, c)
    {
        this.StartPoint = p1;
        this.EndPoint = p2;
    }
    public void Print()
    {
        Console.WriteLine("Writing Line...");
        Console.WriteLine(this);
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing Line....");
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        return base.ToString() + ", " + this.StartPoint + ", " + this.EndPoint;
    }
}
