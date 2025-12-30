using System;
using System.IO;
class Program
{
    public static void Main()
    {


//-----------------------------PROGRAM    NUMBER    SIX------------------------------
        BankAccount account = new BankAccount(6795);
        account.Withdraw(10000);



        //-------------------program number five----------------------
        /*
        try
        {
        try
        {
            File.ReadAllText("transactions.txt");
        }
            catch (IOException ioEx)//low level exception(technical level)........
        {
            throw new ApplicationException("Unable to load transaction data",ioEx);//exceptional wrapping......
        }
    }
catch (Exception ex)
        {
            Console.WriteLine("Message: " + ex.Message);
            Console.WriteLine("Root Cause: " + ex.InnerException.Message);
}
        */




        
//--------program number four------        
        /*try
        {
    // Simulate database operation
            throw new SqlException("Connection failed");
        }
        catch (SqlException ex)
        {
    // Wrap low-level exception into higher-level exception
            throw new Exception("Database operation failed in Service Layer", ex);
        }




//---------------------program three-------------
/*
        FileStream file=null
        try
        {
            file = new FileStream("data.txt",FileMode.Open);
            int data= File.ReadAllByte();
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message());
        }


        */
        //P R O G R A M   N U M B E R    T W O
        /*try
        {
            Console.Write("enter withdrawal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            int serviceCharge = 100;
            int divisionCheck = serviceCharge / int.Parse("1"); //Intentional error


            //File Access
            string data= File.ReadAllText("account.txt");

            //Business Logic
            BankAccount account = new BankAccount();
            account.Withdraw(amount);

            Console.WriteLine("Withdrawal Successfull!! ");
        }
        catch(FormatException ex)
        {
            LogException(ex);
            Console.WriteLine("Invalid input Format!! ");
        }

        catch (DivideByZeroException ex)
        {
            LogException(ex);
            Console.WriteLine("Airthmetic error occurred...");
        }
        catch(FileNotFoundException ex)
        {
            LogException(ex);
            Console.WriteLine("Required file not found");
        }
        catch(InsufficientBalanceException ex)
        {
            LogException(ex);
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            LogException(ex);
            Console.WriteLine("An unexpected error occurred!! ");
        }
        finally
        {
            Console.WriteLine("Transaction attempt completed...");
        }
    }
    static void LogException(Exception ex)
    {
        File.AppendAllText("error.log", DateTime.Now+" | "+ex.GetType().Name+" | "+ex.Message+Environment.NewLine);
    }*/

}  
       
}    
       
       
       
       
       
       
       
       
//---Exception Handling---[============= F I R S T     C O D E============ ]
        /*int a=8;
        int b=0;
        try
        {
            int res =a/b;
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error Occured: "+ex.Message);
        }*/
    
    
