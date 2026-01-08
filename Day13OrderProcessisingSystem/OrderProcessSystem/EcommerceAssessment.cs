using System;
using System.Collections.Generic;

namespace EcommerceAssessment
{
    public class Repository<T>
    {
        private List<T> Items = new List<T>();

        public void Add(T item)
        {
            Items.Add(item);
        }
        public List<T> GetAll()
        {
            return Items;
        }
    }

    class Order
    {
        public int OrderId {get; set;}
        public string CustomerName {get; set;}
        public double Amount {get; set;}


        public string ToString()
        {
            return "OrderId: " + OrderId + ", Customer: " + CustomerName + ", Amount: " + Amount;
        }

        public void OrderValidation(string msg)
        {
            Console.WriteLine("Callback: " + msg);
        }
    }
    public delegate void OrderCallback(string msg);

    class OrderProcessor
    {
        public event Action<string> OrderProcessed;

        public void ProcessOrder(Order order, Func<double, double> taxCalculator, Func<double, double> discountCalculator, Predicate<Order> validator, OrderCallback callback)
        {

            if (!validator(order))
            {
                callback("Order Validation Failed!");
                return;
            }

            double tax = taxCalculator(order.Amount);
            double discount = discountCalculator(order.Amount);

            order.Amount = order.Amount + tax - discount;

            callback($"Order {order.OrderId} processed successfully.");

            OrderProcessed?.Invoke($"Event: Order {order.OrderId} Completed.");
        }
    }
}