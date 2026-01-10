using System;
using System.Collections.Generic;
using DialingCodesApp;

class Program
{
    static void Main()
    {
        Dictionary<int, string> dict;

        Console.WriteLine("Task 1 is below:");
        dict = Task1_EmptyDictionary.GetEmptyDictionary();
        PrintDictionary(dict);

        Console.WriteLine("\nTask 2 is below:");
        dict = Task2_PredefinedDictionary.GetExistingDictionary();
        PrintDictionary(dict);

        Console.WriteLine("\nTask 3 is below:");
        Dictionary<int, string> temp =
            Task3_AddToEmpty.AddCountry(81, "Japan");
        PrintDictionary(temp);

        Console.WriteLine("\nTask 4 is below:");
        dict = Task4_AddToExisting.AddCountry(dict, 44, "United Kingdom");
        PrintDictionary(dict);

        Console.WriteLine("\nTask 5 is below:");
        Console.WriteLine(
            Task5_GetCountryName.GetCountry(dict, 91));

        Console.WriteLine("\nTask 6 is below:");
        Console.WriteLine(
            Task6_CheckCodeExists.Exists(dict, 55));

        Console.WriteLine("\nTask 7 is below:");
        dict = Task7_UpdateDictionary.Update(dict, 91, "Republic of India");
        PrintDictionary(dict);

        Console.WriteLine("\nTask 8 is below:");
        dict = Task8_RemoveCountry.Remove(dict, 1);
        PrintDictionary(dict);

        Console.WriteLine("\nTask 9 is below:");
        Console.WriteLine(
            Task9_LongestCountryName.FindLongest(dict));
    }

    static void PrintDictionary(Dictionary<int, string> dict)
    {
        if (dict.Count == 0)
        {
            Console.WriteLine("Dictionary is empty");
            return;
        }

        foreach (KeyValuePair<int, string> item in dict)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}
