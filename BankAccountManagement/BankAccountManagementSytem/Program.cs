using System;
using BankingSystem;

class Program
{
    static void Main()
    {
        try
        {
            BankAccount account = new BankAccount("ACC1001", 5000);
            account.Withdraw(7000);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (BankOperationException ex)
        {
            Console.WriteLine(ex.Message);
            if (ex.InnerException != null)
                Console.WriteLine("Root Cause: " + ex.InnerException.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }
}
