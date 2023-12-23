using notification;
using Taxation;

namespace Banking;

public class Account
{
    public event TaxationOperation overBalance;
    public event NotificationOperation underBalance;

    public float Balance
    {
        set; get;
    }

    public void Deposit(float amount)
    {
        this.Balance = this.Balance + amount;
        Console.WriteLine("After Deposition your amount is " + this.Balance);
        if (this.Balance >= 800000)
        {

            overBalance(5000);
        }
    }

    public void Withdraw(float amount)
    {
        this.Balance = this.Balance - amount;
        Console.WriteLine("After Withdrawal your amount remaining is " + this.Balance);
        if (this.Balance <= 100000)
        {
            underBalance("Raj", "Your Account is Blocked");
        }
    }
}