using System;
using System.Collections.Generic;

public class Program
{
    public void RegisterEmployee(EmployeeRecord record)
    {
        PayrollBoard.PayrollBoardList.Add(record);
    }

    public Dictionary<string, int> GetOvertimeWeekCounts(List<EmployeeRecord> records, double hoursThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        for (int i = 0; i < records.Count; i++)
        {
            EmployeeRecord emp = records[i];
            int count = 0;

            for (int j = 0; j < emp.WeeklyHours.Length; j++)
            {
                if (emp.WeeklyHours[j] >= hoursThreshold)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                result.Add(emp.EmployeeName, count);
            }
        }

        return result;
    }

    public double CalculateAverageMonthlyPay()
    {
        if (PayrollBoard.PayrollBoardList.Count == 0)
            return 0;

        double totalPay = 0;

        for (int i = 0; i < PayrollBoard.PayrollBoardList.Count; i++)
        {
            totalPay += PayrollBoard.PayrollBoardList[i].GetMonthlyPay();
        }

        return totalPay / PayrollBoard.PayrollBoardList.Count;
    }

    public static void Main(string[] args)
    {
        Program p = new Program();

        while (true)
        {
            Console.WriteLine("\n1. Register Employee");
            Console.WriteLine("2. Show Overtime Summary");
            Console.WriteLine("3. Calculate Average Monthly Pay");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter your choice:\n");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nSelect Employee Type (1-Full Time, 2-Contract):");
                int type = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter Employee Name:");
                string name = Console.ReadLine();

                Console.WriteLine("\nEnter Hourly Rate:");
                double rate = Convert.ToDouble(Console.ReadLine());

                double[] hours = new double[4];
                Console.WriteLine("\nEnter weekly hours (Week 1 to 4):");
                for (int i = 0; i < 4; i++)
                {
                    hours[i] = Convert.ToDouble(Console.ReadLine());
                }

                if (type == 1)
                {
                    Console.WriteLine("\nEnter Monthly Bonus:");
                    double bonus = Convert.ToDouble(Console.ReadLine());

                    FullTimeEmployee ft = new FullTimeEmployee();
                    ft.EmployeeName = name;
                    ft.HourlyRate = rate;
                    ft.MonthlyBonus = bonus;
                    ft.WeeklyHours = hours;

                    p.RegisterEmployee(ft);
                }
                else
                {
                    ContractEmployee ct = new ContractEmployee();
                    ct.EmployeeName = name;
                    ct.HourlyRate = rate;
                    ct.WeeklyHours = hours;

                    p.RegisterEmployee(ct);
                }

                Console.WriteLine("\nEmployee registered successfully");
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nEnter hours threshold:");
                double threshold = Convert.ToDouble(Console.ReadLine());

                Dictionary<string, int> data =
                    p.GetOvertimeWeekCounts(PayrollBoard.PayrollBoardList, threshold);

                if (data.Count == 0)
                {
                    Console.WriteLine("\nNo overtime recorded this month");
                }
                else
                {
                    foreach (KeyValuePair<string, int> item in data)
                    {
                        Console.WriteLine(item.Key + " - " + item.Value);
                    }
                }
            }
            else if (choice == 3)
            {
                double avg = p.CalculateAverageMonthlyPay();
                Console.WriteLine("\nOverall average monthly pay: " + avg);
            }
            else if (choice == 4)
            {
                Console.WriteLine("\nLogging off — Payroll processed successfully!");
                break;
            }
        }
    }
}
