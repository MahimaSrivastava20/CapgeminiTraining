// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using EcommerceAssessment;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Ecommerce Order Processing System!");

        // Task 1: Generic Repository
        Console.WriteLine("----- Task 1 -----");
        Repository<string> repo = new Repository<string>();
        repo.Add("Laptop");
        repo.Add("Tablet");

        Console.WriteLine("Printing Items: ");
        foreach(var item in repo.GetAll())
        {
            Console.WriteLine(item);
        }

        // Task 2: Order Model (ToString)
        Console.WriteLine("------ Task 2 ------");
        Order order1 = new Order()
        {
            OrderId = 101,
            CustomerName = "Alice",
            Amount = 5000
        };

        Console.WriteLine(order1.ToString());

        // Task 3: Custom Delegate Callback
        Console.WriteLine("-------- Task 3 -------");
        OrderCallback delegates = order1.OrderValidation;
        delegates("Order validation failed.");


        // Task 4: Implement the Order Processor
        Console.WriteLine("-------- Task 4 -------");
        OrderProcessor processor = new OrderProcessor();

        Func<double, double> taxCalculator = (amount) => amount * 0.18;

        Func<double, double> discountCalculator = (amount) => amount * 0.10;

        Predicate<Order> validator = (order) => order.Amount >= 3000;

        OrderCallback callback = (msg) => Console.WriteLine("Callback: " + msg);
        

        Order order2 = new Order()
        {
            OrderId = 102,
            CustomerName = "Arjun",
            Amount = 1000
        };

        processor.ProcessOrder(order1, taxCalculator, discountCalculator, validator, callback);
        processor.ProcessOrder(order2, taxCalculator, discountCalculator, validator, callback);


        // Task 5: Order Processing Execution & Sorting
        Console.WriteLine("-------- Task 5 -------");
        Repository<Order> store = new Repository<Order>();

        store.Add(new Order{ OrderId = 1, CustomerName = "Alice", Amount = 5000 });
        store.Add(new Order { OrderId = 2, CustomerName = "Bob", Amount = 2000 });
        store.Add(new Order { OrderId = 3, CustomerName = "Charlie", Amount = 8000 });

        Action<string> logger = (msg) => Console.WriteLine("Logger: " + msg);
        Action<string> notifier = (msg) => Console.WriteLine("Notifier: " + msg);

        processor.OrderProcessed += logger;
        processor.OrderProcessed += notifier;

        foreach(var order in store.GetAll())
        {
            processor.ProcessOrder(order, taxCalculator, discountCalculator, validator, callback);
            Console.WriteLine();
        }

        // Sorting Based on Amount
        Comparison<Order> orderComparison = (o1, o2) => o2.Amount.CompareTo(o1.Amount);

        List<Order> orders = store.GetAll();
        orders.Sort(orderComparison);

        Console.WriteLine("Sorted Orders: ");

        foreach(Order ord in orders)
        {
            Console.WriteLine(ord.ToString());
        }


    }
}