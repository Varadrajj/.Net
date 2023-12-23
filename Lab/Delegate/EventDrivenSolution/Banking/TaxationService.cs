namespace Taxation;

public static class TaxationService
{
    public static void PayIncomeTax(float amount)
    {
        Console.WriteLine(amount + " Income Tax is deducted from your account.");
    }
    public static void PayGstTax(float amount)
    {
        Console.WriteLine(amount + " GST Tax is deducted from your account.");
    }
    public static void PayServiceTax(float amount)
    {
        Console.WriteLine(amount + " Service Tax is deducted from your account.");
    }
    public static void PaySalesTax(float amount)
    {
        Console.WriteLine(amount + " Sales Tax is deducted from your account.");
    }
}