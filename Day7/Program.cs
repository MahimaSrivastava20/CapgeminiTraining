using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (name == null)
        {
            Console.WriteLine("Input is NULL");
        }
        else if (name == "")
        {
            Console.WriteLine("Input is EMPTY");
        }
        else
        {
            Console.WriteLine("You entered: " + name);
        }
    }
}
