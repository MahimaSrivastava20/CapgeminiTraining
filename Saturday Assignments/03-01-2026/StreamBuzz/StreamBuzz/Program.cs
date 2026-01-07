using System;
using System.Collections.Generic;

public class CreatorStats
{
    public string CreatorName { get; set; }
    public double[] WeeklyLikes { get; set; }

    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
}

public class Program
{
    public void RegisterCreator(CreatorStats record)
    {
        CreatorStats.EngagementBoard.Add(record);
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        for (int i = 0; i < records.Count; i++)
        {
            int count = 0;
            for (int j = 0; j < records[i].WeeklyLikes.Length; j++)
            {
                if (records[i].WeeklyLikes[j] >= likeThreshold)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                result.Add(records[i].CreatorName, count);
            }
        }

        return result;
    }

    public double CalculateAverageLikes()
    {
        double sum = 0;
        int totalWeeks = 0;

        for (int i = 0; i < CreatorStats.EngagementBoard.Count; i++)
        {
            for (int j = 0; j < CreatorStats.EngagementBoard[i].WeeklyLikes.Length; j++)
            {
                sum += CreatorStats.EngagementBoard[i].WeeklyLikes[j];
                totalWeeks++;
            }
        }

        if (totalWeeks == 0)
            return 0;

        return sum / totalWeeks;
    }

    public static void Main()
    {
        Program p = new Program();
        bool run = true;

        while (run)
        {
            Console.WriteLine("1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CreatorStats cs = new CreatorStats();

                Console.WriteLine("Enter Creator Name:");
                cs.CreatorName = Console.ReadLine();

                cs.WeeklyLikes = new double[4];
                Console.WriteLine("Enter weekly likes (Week 1 to 4):");
                for (int i = 0; i < 4; i++)
                {
                    cs.WeeklyLikes[i] = Convert.ToDouble(Console.ReadLine());
                }

                p.RegisterCreator(cs);
                Console.WriteLine("Creator registered successfully");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter like threshold:");
                double threshold = Convert.ToDouble(Console.ReadLine());

                Dictionary<string, int> data =
                    p.GetTopPostCounts(CreatorStats.EngagementBoard, threshold);

                if (data.Count == 0)
                {
                    Console.WriteLine("No top-performing posts this week");
                }
                else
                {
                    foreach (KeyValuePair<string, int> item in data)
                    {
                        Console.WriteLine(item.Key + " - " + item.Value);
                    }
                }
                Console.WriteLine();
            }
            else if (choice == 3)
            {
                double avg = p.CalculateAverageLikes();
                Console.WriteLine("Overall average weekly likes: " + avg);
                Console.WriteLine();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                run = false;
            }
        }
    }
}
