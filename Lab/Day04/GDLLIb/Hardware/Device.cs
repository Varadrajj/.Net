namespace Hardware;
public class Device : IPrinter, IScanner
{
    public void print()
    {
        Console.WriteLine("Printer is Printing...");
    }
    public void scan()
    {
        Console.WriteLine("Scanner is Scanning...");
    }
}