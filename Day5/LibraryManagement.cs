using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public enum UserRole
    {
        Admin,
        Librarian,
        Member
    }

    public enum ItemStatus
    {
        Available,
        Borrowed,
        Reserved,
        Lost
    }

    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ItemID { get; set; }

        public abstract void DisplayItemDetails();
        public abstract double CalculateLateFee(int days);
    }

    public partial class LibraryAnalytics
    {
        public static int TotalBorrowedItems { get; set; }
    }

    public partial class LibraryAnalytics
    {
        public static void DisplayAnalytics()
        {
            Console.WriteLine("Total Items Borrowed: " + TotalBorrowedItems);
        }
    }

    public interface IReservable
    {
        void Reserve();
    }

    public interface INotifiable
    {
        void SendNotification(string message);
    }

    namespace Items
    {
        public class Book : LibraryItem, IReservable, INotifiable
        {
            public override void DisplayItemDetails()
            {
                Console.WriteLine("Item Type: Book");
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("Item ID: " + ItemID);
            }

            public override double CalculateLateFee(int days)
            {
                return days * 1.0;
            }

            void IReservable.Reserve()
            {
                Console.WriteLine("Book reserved successfully.");
            }

            void INotifiable.SendNotification(string message)
            {
                Console.WriteLine("Notification sent: " + message);
            }
        }

        public class Magazine : LibraryItem
        {
            public override void DisplayItemDetails()
            {
                Console.WriteLine("Item Type: Magazine");
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("Item ID: " + ItemID);
            }

            public override double CalculateLateFee(int days)
            {
                return days * 0.5;
            }
        }
    }

    namespace Users
    {
        public class Member
        {
            public UserRole Role { get; set; }
        }
    }
}
