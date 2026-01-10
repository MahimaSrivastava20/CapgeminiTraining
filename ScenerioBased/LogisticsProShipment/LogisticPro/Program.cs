// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace LogisticsApp
{
    // --- DATA MODEL LAYER ---
    public class Shipment
    {
        public string ShipmentCode { get; set; }
        public string TransportMode { get; set; }
        public double Weight { get; set; }
        public int StorageDays { get; set; }
    }

    // --- BUSINESS LOGIC LAYER ---
    public class ShipmentDetails : Shipment
    {
        // Validates if the ShipmentCode follows the "GC#NNN" format.
        // Rule: Length 6, starts with GC#, followed by 3 digits
        public bool ValidateShipmentCode()
        {
            if (string.IsNullOrEmpty(ShipmentCode) || ShipmentCode.Length != 6)
                return false;

            if (!ShipmentCode.StartsWith("GC#"))
                return false;

            string numericPart = ShipmentCode.Substring(3);
            return int.TryParse(numericPart, out _);
        }

 
        // Calculates the total cost based on TransportMode, Weight, and StorageDays.
        // Formula: (Weight * RatePerKg) + Math.Sqrt(StorageDays)

        public double CalculateTotalCost()
        {
            double pricePerKg = 0;

            // Case-sensitive transport mode pricing
            switch (TransportMode)
            {
                case "Sea":
                    pricePerKg = 15;
                    break;
                case "Air":
                    pricePerKg = 50;
                    break;
                case "Land":
                    pricePerKg = 25;
                    break;
                default:
                    return 0.00;
            }

            double cost = (Weight * pricePerKg) + Math.Sqrt(StorageDays);
            return Math.Round(cost, 2);
        }
    }

    // --- PRESENTATION LAYER ---
    class Program
    {
        static void Main(string[] args)
        {
            ShipmentDetails shipment = new ShipmentDetails();

            // 1. Get and Validate Shipment Code
            Console.WriteLine("Enter the shipment code:");
            shipment.ShipmentCode = Console.ReadLine();

            if (shipment.ValidateShipmentCode())
            {
                // 2. Get additional inputs
                Console.WriteLine("Enter transport mode (Sea/Air/Land):");
                shipment.TransportMode = Console.ReadLine();

                Console.WriteLine("Enter weight (kg):");
                shipment.Weight = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter storage days:");
                shipment.StorageDays = int.Parse(Console.ReadLine());

                // 3. Output Result
                double finalCost = shipment.CalculateTotalCost();
                Console.WriteLine($"The total shipping cost is {finalCost:F2}");
            }
            else
            {
                Console.WriteLine("Invalid shipment code");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
