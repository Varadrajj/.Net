namespace Utility;
using System.IO;

public static class Helper
{

    public static void Operation1()
    {
        int count = 0;
        while (true)
        {
            count++;
            Console.WriteLine("Secondary Thread code execution");
            Thread.Sleep(1000);
            Console.WriteLine("Perfoming high computation task");
            Thread th1 = Thread.CurrentThread;
            Console.WriteLine("Secondary Thread Id:" + th1.ManagedThreadId);
            Console.WriteLine("Secondary Thread Priority:" + th1.Priority);
            Console.WriteLine("Count =" + count);
            FileIOManager mgr = new FileIOManager();
            lock (mgr)
            {
                mgr.WriteData();
                var result = "sdfsdfsdfsdf";
                result = result + "sdfsdfsdfsdfsd";
                result = mgr.ReadData();

            }





        }
    }
}

