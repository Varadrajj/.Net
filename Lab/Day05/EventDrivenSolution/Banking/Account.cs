namespace Banking;
public class Account
{
    public float Balance { set; get; }
    public void deposit(float amount)
    {
        Console.WriteLine("Amount is Deposited...", amount);
    }
    public void withDraw(float amount)
    {
        Console.WriteLine("Amount is WithDrawn...");
    }

}