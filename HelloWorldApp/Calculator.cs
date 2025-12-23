using System.IO.Compression;
namespace HelloWorldApp
{  
class Calculator
{
    int number1;
    int number2;
    int result;

    public void Add()
    {
        Console.WriteLine("Enter First Number");
        number1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        number2=Convert.ToInt32(Console.ReadLine());
        result=number1+number2;
        Console.WriteLine($"Sum of the Number is {result}");
    }
    public void Subtract()
    {
        Console.WriteLine("Enter First Number");
        number1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        number2=Convert.ToInt32(Console.ReadLine());
        result=number1-number2;
        Console.WriteLine($"Subtraction of number is {result}");

    }
    public void Multiply()
    {
        Console.WriteLine("Enter first number");
        number1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second number");
        number2=Convert.ToInt32(Console.ReadLine());
        result=number1*number2;
        Console.WriteLine($"Multiplication of numbers are {result}");
    }
    public void Divide()
    {
        Console.WriteLine("Enter first number");
        number1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second number");
        number2=Convert.ToInt32(Console.ReadLine());
        result=number1/number2;
        Console.WriteLine($"Division of numbers are {result}");
    }
    public void Remainder()
    {
        Console.WriteLine("Enter first number");
        number1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second number");
        number2=Convert.ToInt32(Console.ReadLine());
        result= number1%number2;
        Console.WriteLine($"Remainder of numbers is {result}");
    }
}
}





/*
using System;
using HelloWorldApp;
class HelloWorld
{
    public static void Main(string[]arg)
    {
        while(true)
        {
            Console.WriteLine("\n ***FINANCE RULES MENU***");
            Console.WriteLine("1. Check loan eligibility");
            Console.WriteLine("2. Calculate tax");
            Console.WriteLine("3. Enter transaction");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice");

            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    CheckLoanEligibility();
                    break;

                case 2:
                    CalculateTax();
                    break;

                case 3:
                    EnterTransaction();
                    break;

                case4:
                    Console.WriteLine("Exit");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    static void CheckLoanEligibility()
    {
        Console.WriteLine("Please Enter your age: ");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter monthl income: ");
        double mi=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Loan Eligibility status: ");

        if(age>=21 && mi>=30000)
        {
            Console.WriteLine("Eligible for the loan");
        }
        else
        {
            Console.WriteLine("Not eligible for the loan because of your age or your salary");
        }
    }
    static void CalculateTax()
    {
        Console.WriteLine("Enter your Annual Income: ");
        double AnnualIncome=Convert.ToDouble(Console.ReadLine());
        double tax;

        if(AnnualIncome<=250000)
        tax=0;
        else if(AnnualIncome<=500000)
        tax=0.05;
        else if(AnnualIncome<=1000000)
        tax=0.20;
        else
        tax=0.30;
        double TaxAmount=AnnualIncome*tax;

        Console.WriteLine("Tax Amount= "+TaxAmount);
    }

    static void EnterTransaction()
    {
        int mt=5;
        double totalAmount=0;
        int validCount=0;
        Console.WriteLine(" Enter Transactions ");
        for(int i=1;i<=mt;i++)
        {
            Console.WriteLine("Enter amount if transaction "+i+":");
            double amount=Convert.ToDouble(Console.ReadLine());

            if(amount>=0)
            {
                totalAmount+=amount;
                validCount++;
            }
            else
            {
                Console.WriteLine("Negative Amount not allowed");
            }
        }
        Console.WriteLine("Transaction Summary ");
        Console.WriteLine("Total Valid Transaction "+validCount);
        Console.WriteLine("Total Amount "+totalAmount);
    }
}*/