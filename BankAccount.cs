namespace TorsdagExercise;

public class BankAccount
{
    private int balance;
    public int Balance;

    public void Deposit(int amount)
    {
        balance += amount;
    }
    public void Withdraw(int amount)
    {
        balance -= amount;
    }
    public void GetBalance()
    {
        Console.WriteLine($"You have {balance} SEK in your account");
    }


}