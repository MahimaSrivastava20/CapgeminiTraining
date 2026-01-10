// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace HealthSyncApp
{
    // --- ABSTRACT LAYER ---
    public abstract class Consultant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double PayoutAmount { get; set; }

        // ID validation: Length 6, starts with DR, last 4 digits numeric
        public bool ValidateConsultantId()
        {
            if (string.IsNullOrEmpty(Id) || Id.Length != 6)
                return false;

            if (!Id.StartsWith("DR"))
                return false;

            return int.TryParse(Id.Substring(2), out _);
        }

        // Abstract method for payout logic
        public abstract void CalculateGrossPayout();

        // Virtual method for dynamic tax rate
        public virtual double GetTaxRate()
        {
            return (PayoutAmount > 5000) ? 0.15 : 0.05;
        }

        // Applies tax to payout
        public void ApplyTax()
        {
            double rate = GetTaxRate();
            double tax = PayoutAmount * rate;
            PayoutAmount -= tax;
        }
    }

    // --- IMPLEMENTATION LAYER ---
    public class InHouse : Consultant
    {
        public double MonthlyStipend { get; set; }

        public override void CalculateGrossPayout()
        {
            double allowance = 0.20 * MonthlyStipend;
            double bonus = 0.10 * MonthlyStipend;
            PayoutAmount = MonthlyStipend + allowance + bonus;
        }
    }

    public class Visiting : Consultant
    {
        public int ConsultationsCount { get; set; }
        public int RatePerVisit { get; set; }

        public override void CalculateGrossPayout()
        {
            PayoutAmount = ConsultationsCount * RatePerVisit;
        }

        public override double GetTaxRate()
        {
            return 0.10;
        }
    }

    // --- ENTRY POINT ---
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== HealthSync Consultant Billing System ===");
                Console.WriteLine("1. In-House Consultant");
                Console.WriteLine("2. Visiting Consultant");
                Console.Write("Choose option: ");

                int choice = int.Parse(Console.ReadLine());
                Consultant consultant = (choice == 1) ? new InHouse() : new Visiting();

                Console.Write("Enter Consultant ID (DRxxxx): ");
                consultant.Id = Console.ReadLine();

                if (!consultant.ValidateConsultantId())
                {
                    Console.WriteLine("Invalid Consultant ID");
                    return;
                }

                Console.Write("Enter Consultant Name: ");
                consultant.Name = Console.ReadLine();

                if (consultant is InHouse ih)
                {
                    Console.Write("Enter Monthly Stipend: ");
                    ih.MonthlyStipend = double.Parse(Console.ReadLine());
                }
                else if (consultant is Visiting v)
                {
                    Console.Write("Enter Consultation Count: ");
                    v.ConsultationsCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter Rate per Visit: ");
                    v.RatePerVisit = int.Parse(Console.ReadLine());
                }

                consultant.CalculateGrossPayout();
                double gross = consultant.PayoutAmount;

                consultant.ApplyTax();

                Console.WriteLine("\n--- Payment Summary ---");
                Console.WriteLine($"ID: {consultant.Id}");
                Console.WriteLine($"Name: {consultant.Name}");
                Console.WriteLine($"Gross Payout: {gross:F2}");
                Console.WriteLine($"Net Payout: {consultant.PayoutAmount:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
