using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // TASK 1 – DYNAMIC PRODUCT PRICE ANALYSIS (ARRAY)
        Console.WriteLine("Welcome to Enterprise Application!");
        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter product prices: ");
            int num = int.Parse(Console.ReadLine() ?? "0");
            if (num >= 0)
                arr[i] = num;
        }

        double avg = FindAveragePrice(arr, n);
        Console.WriteLine("Average Price: " + avg);

        Console.Write("Before Sorting: ");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();

        Array.Sort(arr);

        Console.Write("After Sorting: ");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            if (arr[i] < avg)
                arr[i] = 0;
        }

        Console.Write("After Modification: ");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();

        Array.Resize(ref arr, n + 5);
        for (int i = n; i < n + 5; i++)
            arr[i] = (int)avg;

        Console.Write("Final Array: ");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();

        // TASK 2 – BRANCH SALES ANALYSIS (2D ARRAY)
        Console.WriteLine("Task two----");
        Console.Write("Enter No. of Branches: ");
        int b = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter No. of Months: ");
        int m = int.Parse(Console.ReadLine() ?? "0");

        int[,] matrix = new int[b, m];

        for (int i = 0; i < b; i++)
        {
            for (int j = 0; j < m; j++)
                matrix[i, j] = int.Parse(Console.ReadLine() ?? "0");
        }

        int highestSale = -1;
        for (int i = 0; i < b; i++)
        {
            int totalSale = 0;
            for (int j = 0; j < m; j++)
            {
                totalSale += matrix[i, j];
                if (matrix[i, j] > highestSale)
                    highestSale = matrix[i, j];
            }
            Console.WriteLine($"Total Sales for Branch {i + 1}: {totalSale}");
        }
        Console.WriteLine("Global Highest Sale: " + highestSale);

        // TASK 3 – JAGGED ARRAY]
        Console.WriteLine("Task 3");
        int[][] jaggedArray = new int[b][];

        for (int i = 0; i < b; i++)
        {
            List<int> temp = new List<int>();
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] >= avg)
                    temp.Add(matrix[i, j]);
            }
            jaggedArray[i] = temp.ToArray();
        }

        Console.WriteLine("Jagged Array Content:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
                Console.Write(jaggedArray[i][j] + " ");
            Console.WriteLine();
        }

        // TASK 4 – LIST & HASHSET (NO LINQ)
        Console.WriteLine("Task four--");
        Console.Write("Enter No. of Customer Transactions: ");
        int transactionNo = int.Parse(Console.ReadLine() ?? "0");

        List<int> list = new List<int>();
        for (int i = 0; i < transactionNo; i++)
            list.Add(int.Parse(Console.ReadLine() ?? "0"));

        HashSet<int> hashSet = new HashSet<int>();
        for (int i = 0; i < list.Count; i++)
            hashSet.Add(list[i]);

        List<int> cleanedList = new List<int>();
        foreach (int item in hashSet)
            cleanedList.Add(item);

        Console.Write("Original List: ");
        for (int i = 0; i < list.Count; i++)
            Console.Write(list[i] + " ");
        Console.WriteLine();

        Console.Write("Cleaned List: ");
        for (int i = 0; i < cleanedList.Count; i++)
            Console.Write(cleanedList[i] + " ");
        Console.WriteLine();

        Console.WriteLine("Duplicates Removed: " + (list.Count - cleanedList.Count));

        // TASK 5 – DICTIONARY & SORTEDLIST
        Console.WriteLine("Task five");
        Console.Write("Enter No. of Transactions: ");
        int noOfTransaction;
        while (!int.TryParse(Console.ReadLine(), out noOfTransaction) || noOfTransaction <= 0)
            Console.WriteLine("Invalid Input");

        Dictionary<int, double> dict = new Dictionary<int, double>();

        for (int i = 0; i < noOfTransaction; i++)
        {
            Console.Write("Enter Transaction ID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine() ?? "0");

            dict[id] = amount;
        }

        SortedList<int, double> sortedList = new SortedList<int, double>();
        foreach (KeyValuePair<int, double> item in dict)
        {
            if (item.Value >= avg)
                sortedList.Add(item.Key, item.Value);
        }

        Console.WriteLine("Filtered Transactions:");
        foreach (KeyValuePair<int, double> item in sortedList)
            Console.WriteLine(item.Key + " -> " + item.Value);

        // TASK 6 – STACK & QUEUE
        Console.WriteLine("Task six");
        Console.Write("Enter No. of Operations: ");
        int noOfOperation;
        while (!int.TryParse(Console.ReadLine(), out noOfOperation) || noOfOperation <= 0)
            Console.WriteLine("Invalid Input");

        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < noOfOperation; i++)
        {
            string op = Console.ReadLine() ?? "";
            queue.Enqueue(op);
            stack.Push(op);
        }

        Console.WriteLine("Processing Queue:");
        while (queue.Count > 0)
            Console.WriteLine(queue.Dequeue());

        Console.WriteLine("Undo Last 2:");
        for (int i = 0; i < 2 && stack.Count > 0; i++)
            Console.WriteLine(stack.Pop());

        // TASK 7 – HASHTABLE & ARRAYLIST
        Console.WriteLine("Task seven----");
        Console.Write("Enter No. of Users: ");
        int noOfUser;
        while (!int.TryParse(Console.ReadLine(), out noOfUser) || noOfUser <= 0)
            Console.WriteLine("Invalid Input");

        Hashtable hstable = new Hashtable();
        ArrayList arrayList = new ArrayList();

        for (int i = 0; i < noOfUser; i++)
        {
            string user = Console.ReadLine() ?? "";
            string role = Console.ReadLine() ?? "";

            hstable.Add(user, role);
            arrayList.Add(user);
            arrayList.Add(role);
        }

        Console.WriteLine("Hashtable Data:");
        foreach (DictionaryEntry entry in hstable)
            Console.WriteLine(entry.Key + " -> " + entry.Value);

        Console.WriteLine("ArrayList Data:");
        arrayList.Add(100);
        arrayList.Add('X');

        foreach (object item in arrayList)
            Console.WriteLine(item + " - " + item.GetType());

        Console.WriteLine("Thanks for using Enterprise System!");
    }

    public static double FindAveragePrice(int[] arr, int n)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
            sum += arr[i];
        return sum / n;
    }
}
