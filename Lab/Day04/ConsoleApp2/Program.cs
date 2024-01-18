// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Hardware;
using TransFlower.Drawing;
using System.Collections.Generic;

Device driver = new Device();
driver.print();
driver.scan();

List<Shape> shapes = new List<Shape>();

Line l = new Line();
l.StartPoint = new TransFlower.Drawing.Point(35, 40);
l.EndPoint = new TransFlower.Drawing.Point(67, 100);
l.color = "red";
l.width = 2;

Point center = new Point(20, 20);
Circle c = new Circle(10, center, "blue", 3);
c.Draw();

shapes.Add(l);
shapes.Add(c);
Console.WriteLine("All Shapes Are Showing...");
foreach (Shape s in shapes)
{
    Console.WriteLine(s);
}