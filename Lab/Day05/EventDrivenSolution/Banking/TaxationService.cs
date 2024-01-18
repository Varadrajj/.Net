namespace Taxation;
public static class TaxationService
{
    public static void paySalesTax(float amount)
    {
        Console.WriteLine("Sales Tax " + amount + " is deducted from your bank account");
    }
    public static void payIncomeTax(float amount)
    {
        Console.WriteLine("Income Tax " + amount + " is deducted from your bank account");
    }
    public static void payServiceTax(float amount)
    {
        Console.WriteLine("Service Tax " + amount + " is deducted from your bank account");
    }
    public static void payGSTTax(float amount)
    {
        Console.WriteLine("GSTTax Tax " + amount + " is deducted from your bank account");
    }

}