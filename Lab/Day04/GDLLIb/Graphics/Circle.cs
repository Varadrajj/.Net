
using Hardware;
namespace TransFlower.Drawing;
public class Circle : Shape, IPrinter
{
    public int radius { get; set; }
    public Point centre { get; set; }
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle...");
        Console.WriteLine(this);
    }
    void IPrinter.print()
    {
        Console.WriteLine("Printing Circle...");
        Console.WriteLine(this);
    }
    public Circle() : base()
    {
        this.centre = new Point(0, 0);
        this.radius = 4;
    }
    public Circle(int r, Point c, string col, int w) : base(col, w)
    {
        this.centre = c;
        this.radius = r;
    }
    public override string ToString()
    {
        return base.ToString() + "Radius =" + this.radius + "Center =" + this.centre;
    }
}