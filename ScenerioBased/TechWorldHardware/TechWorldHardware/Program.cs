// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class Computer
{
    public string Processor { get; set; }
    public int RamSize { get; set; }
    public int HardDiskSize { get; set; }
    public int GraphicCard { get; set; }
}

public class Desktop : Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt { get; set; }

    public double DesktopPriceCalculation()
    {
        int processorCost = 0;

        if (Processor == "i3")
            processorCost = 1500;
        else if (Processor == "i5")
            processorCost = 3000;
        else if (Processor == "i7")
            processorCost = 4500;

        double price =
            processorCost +
            (RamSize * 200) +
            (HardDiskSize * 1500) +
            (GraphicCard * 2500) +
            (MonitorSize * 250) +
            (PowerSupplyVolt * 20);

        return price;
    }
}

public class Laptop : Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }

    public double LaptopPriceCalculation()
    {
        int processorCost = 0;

        if (Processor == "i3")
            processorCost = 2500;
        else if (Processor == "i5")
            processorCost = 5000;
        else if (Processor == "i7")
            processorCost = 6500;

        double price =
            processorCost +
            (RamSize * 200) +
            (HardDiskSize * 1500) +
            (GraphicCard * 2500) +
            (DisplaySize * 250) +
            (BatteryVolt * 20);

        return price;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Desktop");
        Console.WriteLine("2.Laptop");
        Console.WriteLine("Choose the option");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Desktop desktop = new Desktop();

            Console.WriteLine("Enter the processor");
            desktop.Processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            desktop.RamSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            desktop.HardDiskSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            desktop.GraphicCard = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the monitor size");
            desktop.MonitorSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power supply volt");
            desktop.PowerSupplyVolt = int.Parse(Console.ReadLine());

            Console.WriteLine("Desktop price is " + desktop.DesktopPriceCalculation());
        }
        else if (choice == 2)
        {
            Laptop laptop = new Laptop();

            Console.WriteLine("Enter the processor");
            laptop.Processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            laptop.RamSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            laptop.HardDiskSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            laptop.GraphicCard = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the display size");
            laptop.DisplaySize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the battery volt");
            laptop.BatteryVolt = int.Parse(Console.ReadLine());

            Console.WriteLine("Laptop price is " + laptop.LaptopPriceCalculation());
        }
    }
}
