// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        HashSet<char> secondWordChars = new HashSet<char>();

        foreach (char c in word2.ToLower())
        {
            secondWordChars.Add(c);
        }

        StringBuilder filtered = new StringBuilder();

        foreach (char c in word1)
        {
            char lower = char.ToLower(c);

            if (IsVowel(lower))
            {
                filtered.Append(c); 
            }
            else
            {
                if (!secondWordChars.Contains(lower))
                {
                    filtered.Append(c);
                }
            }
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < filtered.Length; i++)
        {
            if (i == 0 || filtered[i] != filtered[i - 1])
            {
                result.Append(filtered[i]);
            }
        }

        Console.WriteLine(result.ToString());
    }

    static bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || 
               c == 'o' || c == 'u';
    }
}
