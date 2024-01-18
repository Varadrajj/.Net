using Hardware;
namespace TransFlower.Drawing;
public class Line : Shape, IPrinter
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Line....");
        Console.WriteLine(this);
    }

    void IPrinter.print()
    {
        Console.WriteLine("Printing Line...");
        Console.WriteLine(this);
    }
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }
    public Line() : base()
    {
        this.StartPoint = new Point(0, 0);
        this.EndPoint = new Point(0, 0);
    }
    public Line(Point p1, Point p2, string col, int w) : base(col, w)
    {
        this.StartPoint = p1;
        this.EndPoint = p2;
    }
    public override string ToString()
    {
        return base.ToString() + "StartPoint =" + this.StartPoint + ", EndPoint =" + this.EndPoint;
    }
}