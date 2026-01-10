// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace GymStream
{
    // --- EXCEPTION LAYER ---
    public class InvalidTierException : Exception
    {
        public InvalidTierException(string message) : base(message) { }
    }

    // --- BUSINESS MODEL ---
    public class Membership
    {
        public string Tier { get; set; }
        public int DurationInMonths { get; set; }
        public double BasePricePerMonth { get; set; }

        // Validates Tier and Duration
        public bool ValidateEnrollment()
        {
            if (Tier != "Basic" && Tier != "Premium" && Tier != "Elite")
            {
                throw new InvalidTierException(
                    "Tier not recognized. Please choose Basic, Premium, or Elite."
                );
            }

            if (DurationInMonths <= 0)
            {
                throw new Exception("Duration must be greater than zero.");
            }

            return true;
        }

        // Calculates final bill after discount
        public double CalculateTotalBill()
        {
            double totalPrice = DurationInMonths * BasePricePerMonth;
            double discount = 0;

            switch (Tier)
            {
                case "Basic":
                    discount = 2;
                    break;
                case "Premium":
                    discount = 7;
                    break;
                case "Elite":
                    discount = 12;
                    break;
            }

            double discountAmount = totalPrice * (discount / 100);
            return totalPrice - discountAmount;
        }
    }

    // --- PRESENTATION LAYER ---
    class Program
    {
        static void Main(string[] args)
        {
            Membership member = new Membership();

            try
            {
                Console.WriteLine("--- GymStream Enrollment Portal ---");

                Console.WriteLine("Enter membership tier (Basic/Premium/Elite):");
                member.Tier = Console.ReadLine();

                Console.WriteLine("Enter duration in months:");
                member.DurationInMonths = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter monthly price:");
                member.BasePricePerMonth = Convert.ToDouble(Console.ReadLine());

                if (member.ValidateEnrollment())
                {
                    double finalAmount = member.CalculateTotalBill();
                    Console.WriteLine("\nEnrollment Successful!");
                    Console.WriteLine($"Total amount after discount: {finalAmount:F2}");
                }
            }
            catch (InvalidTierException ex)
            {
                Console.WriteLine("\nError: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError: " + ex.Message);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
