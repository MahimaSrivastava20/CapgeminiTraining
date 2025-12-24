using System;
using System.Collections.Generic;
using LibrarySystem;
using ItemAlias = LibrarySystem.Items;

class Program
{
    static void Main()
    {
        ItemAlias.Book book = new ItemAlias.Book
        {
            Title = "C# Fundamentals",
            Author = "John Doe",
            ItemID = 101
        };

        ItemAlias.Magazine magazine = new ItemAlias.Magazine
        {
            Title = "Tech Today",
            Author = "Jane Doe",
            ItemID = 201
        };

        book.DisplayItemDetails();
        Console.WriteLine("Late Fee for 3 days: " + book.CalculateLateFee(3));

        magazine.DisplayItemDetails();
        Console.WriteLine("Late Fee for 3 days: " + magazine.CalculateLateFee(3));

        IReservable r = book;
        INotifiable n = book;

        r.Reserve();
        n.SendNotification("Your reserved book is ready for pickup.");

        List<LibraryItem> items = new List<LibraryItem>();
        items.Add(book);
        items.Add(magazine);

        foreach (LibraryItem item in items)
        {
            item.DisplayItemDetails();
        }

        LibraryAnalytics.TotalBorrowedItems = 5;
        LibraryAnalytics.DisplayAnalytics();

        LibrarySystem.Users.Member user = new LibrarySystem.Users.Member
        {
            Role = UserRole.Member
        };

        ItemStatus status = ItemStatus.Borrowed;

        Console.WriteLine("User Role: " + user.Role);
        Console.WriteLine("Item Status: " + status);
    }
}
