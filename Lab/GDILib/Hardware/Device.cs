namespace Hardware;

public class HPPrinter : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing is Started...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning is started...");
    }
}
