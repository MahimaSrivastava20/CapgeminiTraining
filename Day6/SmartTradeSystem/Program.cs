using System;
using System.Collections.Generic;

#region TASK 1: Market Price Snapshot (Struct)

struct PriceSnapshot
{
    public string Symbol;
    public double Price;
}

#endregion

#region TASK 2: Base Trade Abstraction

abstract class Trade
{
    public int TradeId { get; set; }
    public string Symbol { get; set; }
    public int Quantity { get; set; }

    public abstract double CalculateTradeValue();

    public override string ToString()
    {
        return $"TradeId: {TradeId}, Symbol: {Symbol}, Qty: {Quantity}";
    }
}

#endregion

#region TASK 3: Equity Trade Implementation

class EquityTrade : Trade
{
    public double? MarketPrice { get; set; } // Nullable type

    public override double CalculateTradeValue()
    {
        double price = MarketPrice ?? 0.0; // Null coalescing
        return price * Quantity;
    }
}

#endregion

#region TASK 4 & 5: Generic Repository + Static Analytics

class TradeRepository<T> where T : Trade
{
    private List<T> trades = new List<T>();

    public void AddTrade(T trade)
    {
        trades.Add(trade);
        TradeAnalytics.TotalTrades++;
        Console.WriteLine("Trade added successfully");
    }

    public List<T> GetAllTrades()
    {
        return trades;
    }
}

static class TradeAnalytics
{
    public static int TotalTrades { get; set; }

    public static void ShowAnalytics()
    {
        Console.WriteLine($"Total Trades Executed: {TotalTrades}");
    }
}

#endregion

#region TASK 6: Extension Methods

static class FinancialExtensions
{
    public static double Brokerage(this double amount)
    {
        return amount * 0.001; // 0.1%
    }

    public static double GST(this double amount)
    {
        return amount * 0.18; // 18%
    }
}

#endregion

class Program
{
    #region TASK 7: Pattern Matching

    static void ProcessTrade(Trade trade)
    {
        if (trade is EquityTrade et)
        {
            Console.WriteLine("Processing Equity Trade");
            Console.WriteLine($"Trade Value: {et.CalculateTradeValue()}");
        }
    }

    #endregion

    static void Main()
    {
        #region TASK 1 Proof

        PriceSnapshot snapshot = new PriceSnapshot
        {
            Symbol = "AAPL",
            Price = 150.50
        };

        Console.WriteLine($"Stock Symbol: {snapshot.Symbol}");
        Console.WriteLine($"Stock Price: {snapshot.Price}");
        Console.WriteLine();

        #endregion

        #region TASK 9: Main Program Flow

        TradeRepository<EquityTrade> repo = new TradeRepository<EquityTrade>();

        EquityTrade trade1 = new EquityTrade
        {
            TradeId = 1,
            Symbol = "AAPL",
            Quantity = 100,
            MarketPrice = 150.50
        };

        EquityTrade trade2 = new EquityTrade
        {
            TradeId = 2,
            Symbol = "MSFT",
            Quantity = 50,
            MarketPrice = null // Missing price
        };

        repo.AddTrade(trade1);
        repo.AddTrade(trade2);

        Console.WriteLine();

        foreach (var trade in repo.GetAllTrades())
        {
            ProcessTrade(trade);

            double value = trade.CalculateTradeValue();
            double brokerage = value.Brokerage();
            double gst = brokerage.GST();

            Console.WriteLine($"Brokerage: {brokerage}");
            Console.WriteLine($"GST: {gst}");
            Console.WriteLine(trade);
            Console.WriteLine();
        }

        #endregion

        #region TASK 8: Boxing and Unboxing

        object boxedCount = TradeAnalytics.TotalTrades; // Boxing
        int unboxedCount = (int)boxedCount;             // Unboxing

        Console.WriteLine($"Boxed Trade Count: {boxedCount}");
        Console.WriteLine($"Unboxed Trade Count: {unboxedCount}");
        Console.WriteLine();

        #endregion

        #region TASK 5 Proof

        TradeAnalytics.ShowAnalytics();

        #endregion
    }
}
