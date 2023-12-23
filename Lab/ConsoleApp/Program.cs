using Hardware;
using Drawing;

HPPrinter printer = new HPPrinter();
printer.Print();
printer.Scan();

List<Shape> shapes = new List<Shape>();

Line l = new Line();
l.StartPoint = new Drawing.Point(10, 20);
l.EndPoint = new Drawing.Point(50, 60);
l.Color = "black";
l.Width = 4;
// Console.WriteLine(l);

Point center = new Point(45, 50);
Console.WriteLine(center);

shapes.Add(l);
// shapes.Add(center);

Console.WriteLine("All Shapes are showing...");
foreach (Shape s in shapes)
{
    Console.WriteLine(s);
}