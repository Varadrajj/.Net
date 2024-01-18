using System.Drawing.Drawing2D;
using TransFlower.Drawing;
namespace Paint;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Line l = new Line();
        l.color = "red";
        l.width = 10;
        l.Draw();
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}