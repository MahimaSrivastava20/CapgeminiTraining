class BankAccount
{
    private decimal Balance;

    BankAccount(decimal amount)
    {
        Balance = amount;
    }

    public void Deposit(decimal amount)
    {
        if(amount < 0)
        {
            Console.WriteLine("Amount should not be in Negative!");
        }
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if(amount <= 0 || amount > Balance)
        {
            Console.WriteLine("Invalid Input!");
        }
        Balance -= amount;
    }
}


class Animal
{
    public virtual void Bark()
    {
        Console.WriteLine("Animal Bark");
    }
}
class Dog : Animal
{
    public override void Bark()
    {
        base.Bark();
        Console.WriteLine("Dog Bark!");
    }
}