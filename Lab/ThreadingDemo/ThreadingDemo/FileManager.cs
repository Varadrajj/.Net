namespace Utility;
using System.IO;

public class FileIOManager
{

    public void ReadData()
    {
        string data = File.ReadAllText(@"d:\DotNet\Products.json");
    }

    public void WriteData()
    {
        string data = "";
        File.WriteAllText(@"d:\DotNet\Products.json");
    }
}