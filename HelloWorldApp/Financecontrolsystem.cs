/*using System;

class Financialcontrolsystem
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n*** FINANCE RULES MENU ***");
            Console.WriteLine("1. Check Loan Eligibility");
            Console.WriteLine("2. Calculate Tax");
            Console.WriteLine("3. Enter Transaction");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice;
            choice=Convert.ToInt32(Console.ReadLine());
   
            switch (choice)
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

                case 4:
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void CheckLoanEligibility()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter monthly income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        if (age >= 21 && income >= 30000)
        {
            Console.WriteLine("You are eligible for the loan.");
        }
        else
        {
            Console.WriteLine("You are NOT eligible for the loan.");
        }
    }

    static void CalculateTax()
    {
        Console.Write("Enter your annual income: ");
        double annualIncome = Convert.ToDouble(Console.ReadLine());

        double taxRate;

        if (annualIncome <= 250000)
            taxRate = 0;
        else if (annualIncome <= 500000)
            taxRate = 0.05;
        else if (annualIncome <= 1000000)
            taxRate = 0.20;
        else
            taxRate = 0.30;

        double taxAmount = annualIncome * taxRate;
        Console.WriteLine("Tax Amount = ₹" + taxAmount);
    }

    static void EnterTransaction()
    {
        int maxTransactions = 5;
        double totalAmount = 0;
        int validCount = 0;

        Console.WriteLine("\nEnter Transactions:");

        for (int i = 1; i <= maxTransactions; i++)
        {
            
            double amount;
            while(true)
            {
                Console.Write("Enter amount for transaction " + i + ": ");
                amount = Convert.ToDouble(Console.ReadLine());

            if (amount >= 0)
            {
                totalAmount += amount;
                break;
            }
            else
            {
                Console.WriteLine("Negative amount not allowed.");
            }
        }
        }
        Console.WriteLine("\n--- Transaction Summary ---");
        Console.WriteLine("Total Valid Transactions: " + validCount);
        Console.WriteLine("Total Amount: ₹" + totalAmount);
    }
}*/
/*

using System;
class Debit
{
    public void ATMWithdrawal()
 {
        Console.Write("Enter withdrawal amount: ₹");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount <= 40000)
            Console.WriteLine("Withdrawal permitted.");
        else
            Console.WriteLine("Daily ATM withdrawal limit exceeded.");
    }

    public void LoanEligibility()
    {
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter monthly income: ₹");
        double income = Convert.ToDouble(Console.ReadLine());

        if (age >= 21 && income >= 30000)
            Console.WriteLine("Eligible for loan.");
        else
            Console.WriteLine("Not eligible for loan.");
    }

    public void TransactionEntry()
    {
        int max = 5;
        double total = 0;

        Console.WriteLine("Enter Transactions:");
        for (int i = 1; i <= max; i++)
        {
            double amount;
            while (true)
            {
                Console.Write("Transaction " + i + ": ₹");
                amount = Convert.ToDouble(Console.ReadLine());

                if (amount >= 0)
                {
                    total += amount;
                    break;
                }
                else
                {
                    Console.WriteLine("Negative amount not allowed.");
                }
            }
        }

        Console.WriteLine("Total Transaction Amount: ₹" + total);
    }

    public void MinimumBalanceCheck()
    {
        Console.Write("Enter current balance: ₹");
        double balance = Convert.ToDouble(Console.ReadLine());

        if (balance < 2000)
            Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
        else
            Console.WriteLine("Minimum balance maintained.");
    }
}

class Credit
{
    public void NetSalary()
    {
        Console.Write("Enter gross salary: ₹");
        double gross = Convert.ToDouble(Console.ReadLine());

        double net = gross - (gross * 0.10);
        Console.WriteLine("Net Salary Credited: ₹" + net);
    }

    public void FDMaturity()
    {
        Console.Write("Enter principal: ₹");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate (%): ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (years): ");
        double t = Convert.ToDouble(Console.ReadLine());

        double maturity = p + (p * r * t) / 100;
        Console.WriteLine("FD Maturity Amount: ₹" + maturity);
    }

    public void BonusEligibility()
    {
        Console.Write("Enter annual salary: ₹");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter years of service: ");
        int years = Convert.ToInt32(Console.ReadLine());

        if (salary >= 500000 && years >= 3)
            Console.WriteLine("Eligible for bonus.");
        else
            Console.WriteLine("Not eligible for bonus.");
    }

    public void CalculateTax()
    {
        Console.Write("Enter annual income: ₹");
        double income = Convert.ToDouble(Console.ReadLine());

        double rate;
        if (income <= 250000) rate = 0;
        else if (income <= 500000) rate = 0.05;
        else if (income <= 1000000) rate = 0.20;
        else rate = 0.30;

        Console.WriteLine("Tax Amount: ₹" + (income * rate));
    }
}

class Program
{
    static void Main()
    {
        Debit debit = new Debit();
        Credit credit = new Credit();

        while (true)
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Debit Operations");
            Console.WriteLine("2. Credit Operations");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nDebit Menu");
                    Console.WriteLine("1. ATM Withdrawal");
                    Console.WriteLine("2. Loan Eligibility");
                    Console.WriteLine("3. Transaction Entry");
                    Console.WriteLine("4. Minimum Balance Check");
                    Console.Write("Select option: ");

                    int d = Convert.ToInt32(Console.ReadLine());
                    if (d == 1) debit.ATMWithdrawal();
                    else if (d == 2) debit.LoanEligibility();
                    else if (d == 3) debit.TransactionEntry();
                    else if (d == 4) debit.MinimumBalanceCheck();
                    else Console.WriteLine("Invalid option.");
                    break;

                case 2:
                    Console.WriteLine("\nCredit Menu");
                    Console.WriteLine("1. Net Salary");
                    Console.WriteLine("2. FD Maturity");
                    Console.WriteLine("3. Bonus Eligibility");
                    Console.WriteLine("4. Tax Calculation");
                    Console.Write("Select option: ");

                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1) credit.NetSalary();
                    else if (c == 2) credit.FDMaturity();
                    else if (c == 3) credit.BonusEligibility();
                    else if (c == 4) credit.CalculateTax();
                    else Console.WriteLine("Invalid option.");
                    break;

                case 3:
                    Console.WriteLine("Program exited successfully.");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
*/


//day3
/*
using System;

class BankAccount
{
    public int accountnumber;
    public double balance;

    public static void Main(string[] args)
    {
        BankAccount acc1 = new BankAccount();
        acc1.accountnumber = Convert.ToInt32(Console.ReadLine());//101;
        acc1.balance = 10000;
        Console.WriteLine("Account Number: " + acc1.accountnumber);
        Console.WriteLine("Balance: " + acc1.balance);
    }
}


*/



/*
using System;
class BankAccount
{
    public int accountnumber;
    private double balance;
public void Deposit(double amount)
{
    balance+=amount;
    Console.WriteLine("Updated Balance"+balance);
}
    public static void Main(string[] args)
    {
        BankAccount acc1 = new BankAccount();
        acc1.accountnumber = Convert.ToInt32(Console.ReadLine());//101;
        acc1.balance = 10000;
        Console.WriteLine("Account Number: " + acc1.accountnumber);
        Console.WriteLine("Balance: " + acc1.balance);
        acc1.Deposit();
    }
}
*/



/*
using System;
class Employee
{
string name;
double salary;
public void DisplayDetails()
{
    Console.WriteLine(name+" earns "+salary);
}
public static void Main(string[]args)
{
    Employee employee = new Employee();
    employee.name= "Dev";
    employee.salary=1000000.30;
    employee.DisplayDetails();
}
}







*/
/*
using System;
class BankAccount
{
    public int accountnumber;
    private double balance;
public void Deposit(double amount)
{
    balance+=amount;
    Console.WriteLine("Updated Balance"+balance);
}
    public static void Main(string[] args)
    {
        BankAccount acc1 = new BankAccount();
        acc1.accountnumber = Convert.ToInt32(Console.ReadLine());//101;
        acc1.balance = 10000;
        Console.WriteLine("Account Number: " + acc1.accountnumber);
        Console.WriteLine("Balance: " + acc1.balance);
        Console.Write("TELL THE AMOUNT TO DEPOSIT: "); 
        acc1.Deposit(Convert.ToDouble(Console.ReadLine()));
    }
}



public static string BankName="SBI";//can be initialised anytime
const double PI=3.14;//can be initialised outside the constructor
public readonly int AccntId;//cannot be changed after initialization; declared inside the constructor

*/

/*

using System;
class Wallet
{
    private double money;
    void AddMoney(double ammount)
    {
        money+=ammount;
    }

    public void GetBalance()
    {
        Console.WriteLine(money);    
    }
    public static void Main(string[]args)
    {
        Wallet wallet=new Wallet();
        Console.Write("Enter Money");
        wallet.money=Convert.ToDouble(Console.ReadLine());
        wallet.AddMoney(4500);
        wallet.GetBalance();

    }
}*/

/*

using System;
class Mathops
{
    public void Add(int a,int b)
    {
        Console.WriteLine(a+b);
    }
    public void Add(int a,int b,int c)
    {
        Console.WriteLine(a+b+c);
    }
    public void Add(int a,int b,int c,int d)
    {
        Console.WriteLine(a+b+c+d);
    }
    public static void Main(string[]args)
    {
        Mathops mathops=new Mathops();
        Console.Write("Addition of two numbers are: ");
        mathops.Add(3,4);
        Console.Write("Addition of three numbers are: ");
        mathops.Add(2,3,4);
        Console.Write("Addition of four numbers are: ");
        mathops.Add(2,3,4,5);
    }
}
*/



//static methods do not need to create object
/*
using System;
class Mathops
{
    public static int Add(int a,int b)
    {
        return a+b;
    }
    public static int Add(int a,int b,int c)
    {
        return a+b+c;
    }
    public static double Add(double a,double b)
    {
        return a+b;
    }
    public static void Main(string[]args)
    {
        Mathops mathops=new Mathops();
        Console.Write("Addition of two numbers are: ");
        Console.WriteLine(Mathops.Add(3,4));
        Console.Write("Addition of three numbers are: ");
        Console.WriteLine(Mathops.Add(2,3,4));
        Console.Write("Addition of two numbers are: ");
        Console.WriteLine(Mathops.Add(2000.67,456.67));
    }
}

*/
///same program without object creation
//
/*
using System;
class Mathops
{
    public static int Add(int a,int b)
    {
        return a+b;
    }

    public static int Add(int a,int b,int c)
    {
        return a+b+c;
    }

    public static double Add(double a,double b)
    {
        return a+b;
    }

    public static void Main(string[]args)
    {
        Console.Write("Addition of two numbers are: ");
        Console.WriteLine(Mathops.Add(3,4));

        Console.Write("Addition of three numbers are: ");
        Console.WriteLine(Mathops.Add(2,3,4));

        Console.Write("Addition of two numbers are: ");
        Console.WriteLine(Mathops.Add(2000.67,456.67));
    }
}
*/

/*
using System;
class Mathops
//if i keep one function as static and one without static then the one used static keyword
//needs to be called by using class name(without object creation) while the one without
//static keyword needs to be called after creating object(object needs to be created)

{
    private static int Add(int a,int b)
    {
        return a+b;
    }
    public static double Add(double a, int b)
    {
        return a+b;
    }
    public double Add(double a,double b)
    {
        return a+b;
    }

    public static void Main(string[]args)
    {
        Mathops mathops=new Mathops();
        Console.Write("Addition of two numbers are: ");
        Console.WriteLine(Mathops.Add(1,2));

        Console.Write("Addition of two numbers are: ");
        Console.WriteLine(Mathops.Add(1.1,2));

        Console.Write("Addition of two numbers are: ");
        Console.WriteLine(mathops.Add(1.1,2.2));
    }
}



*/



/*
using System;

class Person
{
    string name;
    int age;
    string city;
    char gender;

public Person(string name, int age, string city, char gender = 'M')//default argument should be at last.
    {
        this.name = name;
        this.age = age;
        this.city = city;
        this.gender = gender;

        Console.WriteLine(name + " " + age + " " + city + " " + gender);
    }

    public static void Main(string[] args)
    {
        Person obj = new Person(age: 10, name: "Tanya", city: "Dehradun");
        //obj.Person(age: 10, name: "Tanya", city: "Dehradun");
        Person obj2 = new Person("Tam", 10, "City");
        //obj.Person("Tam", 10, "City");
    }
}
*/



//collections: anything that has multiple values
//arrays,linkedlist,stack,queue
//property- private data members.(ease of visibility)....
//foreach loop.....collection

//foreach(datatype var in  collection)

/*
using System;
class arrays{
    public static void main(string[]args)
    {
        int[] arr= {1,2,3,4,5};
        int Sum(paroans int[] num)
    }
}
*/

/*
//print each letter of name

using System;
class Person
{
    public static void Main(string[] args)
    {
    string name;
    name=Console.ReadLine();
        foreach (char ch in name)
        {
            Console.WriteLine(ch);
        }
   
}
}
*/
/*
using System;
class Person
{
    int Sum(params int[] num)
    {
        int total=0;
        foreach(int n in num)
        {
            total+=n;
        }
        return total;
    }
    using System;

class Person
{
    static int Sum(params int[] num)
    {
        int total = 0;

        foreach (int n in num)
        {
            total += n;
        }

        return total;
    }

   public static void Main(string[] args)
    {
        Console.Write("How many numbers do you want to enter? ");
        int count = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result = Sum(numbers);
        Console.WriteLine("Sum is: " + result);
    }
}
}
*/
/*

using System;

class Person
{
    int Sum(params int[] num)
    {
        int total = 0;

        foreach (int n in num)
        {
            total += n;
        }

        return total; 
    }
}

*/
/*
using System;
class Person
{
    int Sum(params int[] num)
    {
        int total = 0;

        foreach (int n in num)
        {
            total += n;
        }

        return total;
    }
}

///same program

using System;

class Person
{
    static int Sum(params int[] num)
    {
        int total = 0;

        foreach (int n in num)
        {
            total += n;
        }

        return total;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Sum(5));
        Console.WriteLine(Sum(5, 10));
        Console.WriteLine(Sum(1, 2, 3));
        Console.WriteLine(Sum(10, 20, 30, 40, 50));
    }
}

*/


/*
//refrence changes the original value.
using System;

class Reference
{
    static int x = 10;

    static void Incbyten(ref int a)
    {
        a = a + 10;
    }

    public static void Main(string[] args)
    {
        Incbyten(ref x);
        Console.WriteLine(x);
    }
}
*/

//out
/*
class Calculator
{
    public static void Divide(int a,int b,out int quotient,out int remainder)
    {
        quotient=a/b;
        remainder=a%b;
    }
}
class Program{
    static void Main()
    {
        int q,r;
        Calculator.Divide(10,3,out q,out r);
        Console.WriteLine("Quotient= "+q);
        Console.WriteLine("Remainder= "+r);
            }
}
*/



//TASK
//two integers taking and finding product and sum using(out)


//in parameter
//ref,params and out((in) is used in this way)
//varaible is passed by reference but no modification allowed.
/*

using System;

class Program
{
    static void Print(in int x)
    {
        Console.WriteLine(x);
    }

    static void Main(string[] args)
    {
        int num = 50;
        Print(num);
    }
}
*/

/*
class Display
{
    public static void Show(in int number)
    {
        Console.WriteLine(number);
        //number=number+10; //not ALLOWED
    }
}
class Program{
    public static void Main(string[]args)
    {
        int x=50;
        Display.Show(in x);
}

}
*/


//methods cant have more than one params.

//what should be last params or default




/*using System;

class Person
{
    static int Sum(int b,int c,int a=10,params int[] num)
    {
        int total = 0;

        foreach (int n in num)
        {
            total += n;
        }
        total+=a;
        return total;
    }

    public static void Main(string[] args)
    {
        //Console.WriteLine(Sum(5));
        //Console.WriteLine(Sum(5, 10));
        Console.WriteLine(Sum(1, 2, 3));
        Console.WriteLine(Sum({10, 20, 30, 40, 50}));//remove brackets if you want to run the program using int b, int c, int a=10....)
    }
}
*/
//params cannot  be used with ref,in,out
//usimg reference...
//local functions(inside the main class)
/*
using System;
class Program
{
    static void Process()
    {
        string status = "Processing...";

        void PrintMsg()
        {
            Console.WriteLine(status);
        }

        PrintMsg();
    }

    static void Main(string[] args)
    {
        Process();
    }
}
*/
/*
//--program--
//calculator parent method- (a,b)
//it has two local methods(add and subtract)

using System;
class Program
{
    static void Calculator(int a, int b)
    {
        void Add()
        {
            Console.WriteLine("Addition = " + (a + b));
        }
        void Subtract()
        {
            Console.WriteLine("Subtraction = " + (a - b));
        }
        Add();
        Subtract();
    }
    static void Main(string[] args)
    {
        Calculator(10, 5);
    }
}
*/

//difference between lambda functions and local functions
//they are one liner- because they are precise usually in one line.
//try to use parent method variable after making local variable static- possible--
//local method access parent method-yess.
//if local methid is static then will it access parent method-yes
//(no access to parent method if local method is static)  <-----------------------
//can local variable be declared as static-? 
//static variable at method level  cant be used-- to use it should be written at class level.
/*

PARENT method
{
PARENT VARIABLE
local method(local var)

}
*/

//c sharp does not allow static local methods.
//static can be used at class level
//codesent
//


/*

using System;
class Program
{
    static void Example()
    {
        int Square(int x)
        {
            return x * x;
        }
        Func<int, int> squareLambda = x => x * x;
        Console.WriteLine(Square(4));
        Console.WriteLine(squareLambda(4));
    }
    static void Main(string[] args)
    {
        Example();
    }
}
*/



//recursion
//power of number using recurssion
/*
using System;

class PowerUsingRecursion
{
    static int Power(int baseNum, int exponent)
    {
        if (exponent == 0)
            return 1;   

        return baseNum * Power(baseNum, exponent - 1); 
    }

    static void Main(string[] args)
    {
        Console.Write("Enter base number: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        int result = Power(baseNum, exponent);

        Console.WriteLine("Result = " + result);
    }
}
*/


//tail recursion-- the last statement is the recursive call.
//boxing- value type to reference type
//unboxing-
//CONSTRUCTORS
//LINQ



/*
using System;
class BankAccount
{
    private int accountNo;
    private double balance;

    public static string BankName = "ABC National Bank";
    public BankAccount(int accNo, double initialBalance)
    {
        accountNo = accNo;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount deposited successfully.");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }
    public void Deposit(ref double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            amount = 0; 
            Console.WriteLine("Amount deposited using ref.");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public bool Withdraw(double amount, out string message)
    {
        if (amount <= 0)
        {
            message = "Invalid withdrawal amount.";
            return false;
        }

        if (amount > balance)
        {
            message = "Insufficient balance.";
            return false;
        }

        balance -= amount;
        message = "Withdrawal successful.";
        return true;
    }

    public void Display()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"Bank Name  : {BankName}");
        Console.WriteLine($"Account No : {accountNo}");
        Console.WriteLine($"Balance    : ₹{balance}");
        Console.WriteLine("----------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Banking System");

        Console.Write("Enter Account Number: ");
        int accNo;
        while (!int.TryParse(Console.ReadLine(), out accNo))
        {
            Console.Write("Invalid input. Enter valid Account Number: ");
        }

        Console.Write("Enter Initial Balance: ");
        double initBalance;
        while (!double.TryParse(Console.ReadLine(), out initBalance))
        {
            Console.Write("Invalid input. Enter valid Balance: ");
        }

        BankAccount account = new BankAccount(accNo, initBalance);

        int choice;
        do
        {
            Console.WriteLine("\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Display Account");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: ");
                    double depAmount;
                    if (double.TryParse(Console.ReadLine(), out depAmount))
                    {
                        account.Deposit(depAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;

                case 2:
                    Console.Write("Enter withdrawal amount: ");
                    double wAmount;
                    if (double.TryParse(Console.ReadLine(), out wAmount))
                    {
                        if (account.Withdraw(wAmount, out string msg))
                            Console.WriteLine(msg);
                        else
                            Console.WriteLine(msg);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;

                case 3:
                    account.Display();
                    break;

                case 4:
                    Console.WriteLine("Thank you for banking with us!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4);
    }
}
*/







  


/*


using System;    
class BankAccount
{
    // Encapsulation (private fields)
    private int accountNo;
    private double balance;

    // Static Field
    public static string BankName = "ABC National Bank";

    // Constructor
    public BankAccount(int accNo, double initialBalance)
    {
        accountNo = accNo;
        balance = initialBalance;
    }

    // Method Overloading - Deposit
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount deposited successfully.");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Overloaded Deposit using ref
    public void Deposit(ref double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            amount = 0; // cleared after deposit
            Console.WriteLine("Amount deposited using ref.");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Withdraw using out
    public bool Withdraw(double amount, out string message)
    {
        if (amount <= 0)
        {
            message = "Invalid withdrawal amount.";
            return false;
        }

        if (amount > balance)
        {
            message = "Insufficient balance.";
            return false;
        }

        balance -= amount;
        message = "Withdrawal successful.";
        return true;
    }

    // Display Account Details
    public void Display()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"Bank Name  : {BankName}");
        Console.WriteLine($"Account No : {accountNo}");
        Console.WriteLine($"Balance    : ₹{balance}");
        Console.WriteLine("----------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Banking System");

        // Safe input for account number
        Console.Write("Enter Account Number: ");
        int accNo;
        while (!int.TryParse(Console.ReadLine(), out accNo))
        {
            Console.Write("Invalid input. Enter valid Account Number: ");
        }

        // Safe input for initial balance
        Console.Write("Enter Initial Balance: ");
        double initBalance;
        while (!double.TryParse(Console.ReadLine(), out initBalance))
        {
            Console.Write("Invalid input. Enter valid Balance: ");
        }

        // Create account
        BankAccount account = new BankAccount(accNo, initBalance);

        int choice;
        do
        {
            Console.WriteLine("\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Display Account");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: ");
                    double depAmount;
                    if (double.TryParse(Console.ReadLine(), out depAmount))
                    {
                        account.Deposit(depAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;

                case 2:
                    Console.Write("Enter withdrawal amount: ");
                    double wAmount;
                    if (double.TryParse(Console.ReadLine(), out wAmount))
                    {
                        if (account.Withdraw(wAmount, out string msg))
                            Console.WriteLine(msg);
                        else
                            Console.WriteLine(msg);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;

                case 3:
                    account.Display();
                    break;

                case 4:
                    Console.WriteLine("Thank you for banking with us!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4);
    }
}
*/


/*
using System;
class Nilanshi
{
    public static void Main(string[]args)
    {
        int n=0;
        Console.WriteLine("Enter Number ");
        n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number= "+n);

    }
}
*/


//Day 4
//what-constructor is a method.
//where - in the class
//when- when objwct is created
//constructors-//it is calle automatically when the object is created.
//why-initiatlization of data members at the time of object creation.
//how- N obj=new N(v1,v2)
//who- compiler.
//this is a reference keyword and it points to the object in use.
//what, why, who, where, when, how
//if constructor is of different name than class name then it is called method and not constructor.


/*
using System;
clas BankAccount
{
    Console.WriteLine("Example of constrctor");

}
public static void Main(string[]args)
{
    BankAccount obj= new BankAccount();

}
*/

//void is not allowed in constructor.
/*
using System;

class BankAccount
{
    int accountNo;

    
    void BankAccount(int accNo)
    {
        accountNo = accNo;
        Console.WriteLine("This is not a constructor");
    }

    public void Display()
    {
        Console.WriteLine("Account No: " + accountNo);
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Display();
    }
}
*/
//can constrcutor be inherited by child class- YES.(base class(child class we can call))

/*
using System;

class BankAccount
{
    // Parent class data members
    protected int accountNo;
    protected double balance;

    // Parent class constructor
    public BankAccount(int accNo, double bal)
    {
        accountNo = accNo;
        balance = bal;
        Console.WriteLine("BankAccount constructor called");
    }

    // Parent class method
    public void Display()
    {
        Console.WriteLine("Account Number : " + accountNo);
        Console.WriteLine("Balance        : " + balance);
    }
}

// Child class
class FixedDeposit : BankAccount
{
    int years;
    double interestRate;

    public FixedDeposit(int accNo, double bal, int yrs, double rate): base(accNo, bal)   
    {
        years = yrs;
        interestRate = rate;
        Console.WriteLine("FixedDeposit constructor called");
    }

    public void CalculateMaturityAmount()
    {
        double maturityAmount = balance +(balance * interestRate * years / 100);
        Console.WriteLine("Maturity Amount: " + maturityAmount);
    }
}

class Program
{
    static void Main()
    {
        FixedDeposit fd = new FixedDeposit(101, 50000, 3, 6.5);
        Console.WriteLine();
        fd.Display();                 
        fd.CalculateMaturityAmount(); 
    }
}
*/

//instance constructor-An instance constructor is a special method of a class that is automatically called 
//when an object (instance) of the class is created.
//static constructor- used to initiaze static members of a class
//this - current object which is callling

/*
using System;

class BankAccount
{
    public double AmountPresent;
    public int TimePeriod;

    public BankAccount(double amountPresent, int timePeriod)
    {
        AmountPresent = amountPresent;
        TimePeriod = timePeriod;

        Console.WriteLine("BankAccount constructor called");
        Console.WriteLine("Amount Present: " + AmountPresent);
        Console.WriteLine("Time Period: " + TimePeriod);
    }
}

class FixedDeposit : BankAccount
{
    public double ROI;

    public FixedDeposit(double roi) : base(10000, 101)
    {
        ROI = roi;
        Console.WriteLine("FixedDeposit constructor called");
        Console.WriteLine("Rate of Interest: " + ROI);
    }
}

class Program
{
    static void Main(string[] args)
    {
        FixedDeposit fd = new FixedDeposit(6.5);
    }
}




//using this keyword;

using System;

class BankAccount
{
    public double balance;
    public int accnum;

    public BankAccount(double balance, int accnum)
    {
        this.balance = balance;
        this.accnum = accnum;

        Console.WriteLine("BankAccount constructor called");
        Console.WriteLine("Balance: " + this.balance);
        Console.WriteLine("Account Number: " + this.accnum);
    }
}

class FixedDeposit : BankAccount
{
    public double roi;

    public FixedDeposit(double roi) : base(10000, 101)
    {
        this.roi = roi;

        Console.WriteLine("FixedDeposit constructor called");
        Console.WriteLine("Rate of Interest: " + this.roi);
    }
}

class Program
{
    static void Main(string[] args)
    {
        FixedDeposit fd = new FixedDeposit(6.5);
    }
}
*/
//use case: to initiaze static variable;
//maybe you want to run some program just once;

//overloaded constructor.- different parameter.
//

/*
using System;

class Product
{
    public string Name;
    public int Price;

    public Product()
    {

    }
    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
// Object initializer- //it is calling the default constructor only-//requires default construtor to run. 
        Product p = new Product
        {
            Name = "Laptop",
            Price = 50000
        };
        Console.WriteLine("Product Name: " + p.Name);
        Console.WriteLine("Product Price: " + p.Price);
    }
}
  */



//getter,setter- set mathod-(value) :refer to the value which we have set when oobject is created.
//they will look like data members.
//they created it for the ease of readibiliy.
// a property will control the read and write assess of private variable
//property doesnt need parameters.
//get- if only get is there then its read only 
//set- if not get then its write only.



/*
//assignment day3

using System;
namespace HospitalSystem
{
    class Patient
    {
        public int PatientId;
        public string Name;
        public int Age;
        private string medicalHistory;
        private static int idCounter=100;

        public patient()
        {

        }
    }
}
*/




/*

//Task--

using System;
class Student
{
    private string name;
    private int age;
    private int marks;

    public string Name
    {
        get{return name;}
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }
    }
    public int Age
    {
        get{return age;}
        set{
            if(value>0)
            {
                age=value;
            }
        }
    }
    public int Marks
    {
        get
        {return marks;}
        set
        {
            if (value >= 0 && value <= 100)
            {
                marks = value;
            }
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "Amit";
        student.Age = 21;
        student.Marks = 88;

        Console.WriteLine("Student Name: " + student.Name);
        Console.WriteLine("Student Age: " + student.Age);
        Console.WriteLine("Student Marks: " + student.Marks);
    }
}
*/



//extended class
/*
using System;

class Student
{
    private string name;
    private int age;
    private int marks;

    public string Name
    {
        get{return name;}
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }
    }

    public int Age
    {
        get{return age;}
        set
        {
            if (value > 0)
            {
                age = value;
            }
        }
    }

    public int Marks
    {
        get{return marks;}
        set
        {
            if (value >= 0 && value <= 100)
            {
                marks = value;
            }
        }
    }

    public int StudentId { get; set; }//-auto implimented.
    public string ResultStatus//read only bcus only get is used.
    {
        get
        {
            if (marks >= 40)
                return "Pass";
            else
                return "Fail";
        }
    }

    private string password;
    public string Password//write only bcus get is not used.
    {
        set
        {
            if (value.Length >= 6)
            {
                password = value;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        s.Name = "Anjali";
        s.Age = 19;
        s.Marks = 72;

        s.StudentId = 101;//read
        s.Password = "secure123";//write

        Console.WriteLine("studentid=" + s.StudentId);
        Console.WriteLine("name=" + s.Name);
        Console.WriteLine("age=" + s.Age);
        Console.WriteLine("marks=" + s.Marks); 
        Console.WriteLine("resul=" + s.ResultStatus);

    }
}

*/
//property with private set.
//init - means initialization at the time of object creation.
//hard to create unmutabke object thats the reason why init was used.
//init different from set.
//expression-bodied properties- code at 11:49am
//public double Area=> Length*Width;
//the operator => is know as expression bodied operator.

/*
using System;

class Student
{
    public int RegistrationNumber { get; private set; }

//init property
    public int AdmissionYear { get; init; }

    public int Marks { get; set; }

    public double Percentage => (Marks / 100.0) * 100;//expression bodied.

    public Student(int regNo)
    {
        RegistrationNumber = regNo;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student(101)
        {
            AdmissionYear = 2024,  // init-only (allowed here)
            Marks = 85
        };

        Console.WriteLine("Registration Number: " + s.RegistrationNumber);
        Console.WriteLine("Admission Year: " + s.AdmissionYear);
        Console.WriteLine("Marks: " + s.Marks);
        Console.WriteLine("Percentage: " + s.Percentage);

        // s.RegistrationNumber = 202;
        // s.AdmissionYear = 2025;
    }
}
*/


//solution by ma'am


/*
using System;

class Student
{
    // =========================
    // PART 1: Normal Properties
    // =========================

    private string name;
    private int age;
    private int marks;
    private string password;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
        }
    }

    public int Marks
    {
        get { return marks; }
        set
        {
            if (value >= 0 && value <= 100)
                marks = value;
        }
    }

    // =========================
    // PART A: Auto-Implemented Property
    // =========================

    public int StudentId { get; set; }

    // =========================
    // PART B: Read-Only Property
    // =========================

    public string Result
    {
        get
        {
            return marks >= 40 ? "Pass" : "Fail";
        }
    }

    // =========================
    // PART C: Write-Only Property
    // =========================

    public string Password
    {
        set
        {
            if (value.Length >= 6)
                password = value;
        }
    }

    // ==============================
    // PART 5: Property with Private Set
    // ==============================

    public int RegistrationNumber { get; private set; }

    // =========================
    // PART 6: Init-Only Property
    // =========================

    public int AdmissionYear { get; init; }

    // =========================
    // PART 7: Expression-Bodied Property
    // =========================

    public double Percentage => (marks / 100.0) * 100;

    // Constructor
    public Student(int regNo)
    {
        RegistrationNumber = regNo;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student(5001)
        {
            AdmissionYear = 2023
        };

        s.StudentId = 101;
        s.Name = "Amit";
        s.Age = 20;
        s.Marks = 78;
        s.Password = "secure123";

        Console.WriteLine("Student ID: " + s.StudentId);
        Console.WriteLine("Name: " + s.Name);
        Console.WriteLine("Age: " + s.Age);
        Console.WriteLine("Marks: " + s.Marks);
        Console.WriteLine("Result: " + s.Result);
        Console.WriteLine("Percentage: " + s.Percentage);
        Console.WriteLine("Registration No: " + s.RegistrationNumber);
        Console.WriteLine("Admission Year: " + s.AdmissionYear);
    }
}*/





//indexers:- are used to access the objects od the class like array using square braces.
//obj[index]
//instead of calling methods like: GetStidents(0); we can write students[0];
//do indexers have name?? NO
//how to know its indexer-[];
//library management assignment

/*
using System;
using System.Collections.Generic;

class Library
{
    private Dictionary<int, string> books = new Dictionary<int, string>();
    public string this[int bookId]
    {
        get
        {
            if (books.ContainsKey(bookId))
            {
                return books[bookId];
            }
            else
            {
                return "Book ID not found";
            }
        }
        set
        {
            books[bookId] = value;
        }
    }

    public string this[string title]
    {
        get
        {
            foreach (KeyValuePair<int, string> book in books)
            {
                if (book.Value == title)
                {
                    return book.Value;
                }
            }
            return "Book title not found";
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        library[21] = "C# Basics";
        library[27] = "Java Fundamentals";
        library[25] = "Data Structures";

        Console.WriteLine(library[21]);
        Console.WriteLine(library[27]);
        Console.WriteLine(library[29]); 

        Console.WriteLine(library["Java Fundamentals"]);
        Console.WriteLine(library["csharp dotnet(.net)"]); 
    }
}
*/
//collection.FirstOrdefault(element=>condition)-----> using this....


/*

using System;
using System.Collections.Generic;
using System.Linq;

class Library
{
    private Dictionary<int, string> books = new Dictionary<int, string>();
    public string this[int bookId]
    {
        get
        {
            if (books.ContainsKey(bookId))
                return books[bookId];
            else
                return "Book ID not found";
        }
        set
        {
            books[bookId] = value;
        }
    }

    public string this[string title]
    {
        get
        {
            var book = books.FirstOrDefault(element => element.Value == title);

            if (book.Value != null)
                return book.Value;
            else
                return "hello its blank....hehe!!!";
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        library[21] = ".net";
        library[22] = "Java";
        library[23] = "English";

        Console.WriteLine(library[21]);
        Console.WriteLine(library[22]);
        Console.WriteLine(library[99]); 

        Console.WriteLine(library["java"]);
        Console.WriteLine(library["maths"]); 
    }
}
*/

//do we have to create child class constructor or is it optional.
//a derived class must call parent class. 
/*
using System;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}

class Student : Person
{
    public int RollNo;

    public Student(string name, int roll) : base(name)
    {
        RollNo = roll;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Amit", 101);

        Console.WriteLine("Student Name: " + s1.Name);
        Console.WriteLine("Student Roll No: " + s1.RollNo);
    }
}
//Single Inheritence- one child class one parent class(one base, one derieved)
//multi level- base class->child class->child class->child class->...
//multiple-> c# doesn't support multiple inheritence---> multiple base classes not allowed.
//          A     B
//           \   /
//            \ /
//             C
//Hirearchy -> opposite of multiple.


//method overriding
//already defined in parent class but child class is uses it defining its own behaviour.
//parents clsas it will provide you a general behaviour but in child class we can give specific behaviour.
//override keyword is to be used in child class. 
//virtual will permit the overriding and override keyword will perform the overriding 
//virtual and override should be used together.

//base - constructor call
//base-method call.    base.parent method


*/
//access modifier
//parent class public- derived class(yes)
//parent class private-derieved class()
//parent class protectd-derievd class(no)
//parent class internal-derievd class()
//parent class protected internal-derived(yes)
//

//sealed keyword is used to restrict 
//sealed class is a class that cannot be inherited by other.
//Sealed class ClassName
//a child class is a  type of parent class
//composition- has a relationship.
//code at 15:14
//Car contains an object of Engine.
//This shows a HAS-A relationship → Car has an Engine.
//This is composition, not inheritance.


//method hiding vs method overriding- allow child class to define method of same name as parent class method
//method hiding occurs when child class defines without using virtual and override keyword.
//static method cannot be overridden
//Sealed method can be hidden- doubt not sure.


/*
//DAY 4- ASSIGNMENT
using System;
using System.Collections.Generic
sealed class Security{
    public void Authenticate()
    {
        Console.WriteLine("This is the confirmation messege..You are Authenticated successfully");
    }
    abstract class Insurancepolicy{
        public int PolicyNumber{get;init;}
        private double premium;
        public double Premium
        {
            get{return premium;}
            set{
                if(value>0)
                {
                    premium=value;
                }
            }
            public string PolicyHolderName{get;set;}
            public virtual double CalculatePremium()
            {
                return Premium;
            }
            public void ShowPolicy()
            {
                Console.WriteLine("Insurance Policy");
            }
        }
        class LifeInsurance: InsurancePolicy
        {
            public override double CalculatePremium()
            {
                return Premium+500;
            }
            public new void ShowPolicy()
            {
                Console.writeLine("Life insurance policy.");
            }
        }
        class HealthInsurance:InsurancePolicy
        {
            public sealed override double CalculatePremium()
            {
               return Premium + 2000; 
            }
        }
        class PolicyDirectory
        {
            private List<InsurancePolicy> policies = new List<InsurancePolicy>();
            public void AddPolicy(InsurancePolicy policy)
            {
                policies.Add(policy);
            }
            public InsurancePolicy this[int index]
    {
        get { return policies[index]; }
    }

    public InsurancePolicy this[string name]
    {
        get
        {
            foreach (var policy in policies)
            {
                if (policy.PolicyHolderName == name)
                    return policy;
            }
            return null;
        }
    }
}

class Program
{
    static void Main()
    {
        Security security = new Security();
        security.Authenticate();
        LifeInsurance life = new LifeInsurance
        {
            PolicyHolderName = "Amit",
            PolicyNumber = 101,
            Premium = 5000
        };

        HealthInsurance health = new HealthInsurance
        {
            PolicyHolderName = "Neha",
            PolicyNumber = 102,
            Premium = 6000
        };

        PolicyDirectory directory = new PolicyDirectory();
        directory.AddPolicy(life);
        directory.AddPolicy(health);

        Console.WriteLine(directory[0].PolicyHolderName);
        Console.WriteLine(directory["Neha"].PolicyNumber);

        InsurancePolicy p1 = life;
        InsurancePolicy p2 = health;

        Console.WriteLine("Life Premium: " + p1.CalculatePremium());
        Console.WriteLine("Health Premium: " + p2.CalculatePremium());

        life.ShowPolicy();   
        p1.ShowPolicy();     
    }
}
*/

/*
using System;

interface IPrintable
{
    void Print();
    void Scan();
}

class Report : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing report");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning report");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPrintable report = new Report();
        report.Print();
        report.Scan();
    }
}

*/
//DAY 5
//abstract method concrete method.
//interface- used for multiple inheritence.
//runtime-orvrriding
//complite time-overloading.
/*
using System;

interface IPrintable
{
    void Print();
    void Scan();
}

class Report : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing report");
    }

    //public void Scan()
    //{
     //   Console.WriteLine("Scanning report");
    //}
}

class Program
{
    static void Main(string[] args)
    {
        IPrintable report = new Report();
        report.Print();
        //report.Scan();
    }
}

*/
/*
//--questions--
using System;
class RobotSafetyException : Exception
{
    public RobotSafetyException(string message) : base(message)
    {
    }
}

class RobotHazardAuditor
{
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        if (armPrecision < 0.0 || armPrecision > 1.0)
        {
            throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
        }

        if (workerDensity < 1 || workerDensity > 20)
        {
            throw new RobotSafetyException("Error: Worker density must be 1-20");
        }

        double machineRiskFactor;

        if (machineryState == "Worn")
        {
            machineRiskFactor = 1.3;
        }
        else if (machineryState == "Faulty")
        {
            machineRiskFactor = 2.0;
        }
        else if (machineryState == "Critical")
        {
            machineRiskFactor = 3.0;
        }
        else
        {
            throw new RobotSafetyException("Error: Unsupported machinery state");
        }

        double hazardRisk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
        return hazardRisk;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
            double armPrecision = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Worker Density (1 - 20):");
            int workerDensity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
            string machineryState = Console.ReadLine();

            RobotHazardAuditor auditor = new RobotHazardAuditor();
            double risk = auditor.CalculateHazardRisk(armPrecision, workerDensity, machineryState);

            Console.WriteLine("Robot Hazard Risk Score: " + risk);
        }
        catch (RobotSafetyException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
*/

//TASK DAY-5



