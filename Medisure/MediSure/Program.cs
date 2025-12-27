using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running) 
        {
            Console.WriteLine("\n================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    BillingService.CreateNewBill();
                    break;
                case 2:
                    BillingService.ViewLastBill();
                    break;
                case 3:
                    BillingService.ClearLastBill();
                    break;
                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid menu option. Please try again.");
                    break;
            }
        }
    }
}
