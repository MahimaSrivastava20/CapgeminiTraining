using System;
using System.Text.RegularExpressions;

namespace LogProcessing
{
    public class LogParser
    {
        private readonly string validLineRegexPattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]\s.+$";
        private readonly string splitLineRegexPattern = @"<\*\*>|<====>|<\^\*>";
        private readonly string quotedPasswordRegexPattern = "\"[^\"]*password[^\"]*\"";
        private readonly string endOfLineRegexPattern = @"end-of-line\\d+";
        private readonly string weakPasswordRegexPattern = @"password[a-zA-Z0-9]+";

        public bool IsValidLine(string text)
        {
            if (text == null)
                return false;

            return Regex.IsMatch(text, validLineRegexPattern);
        }

        public string[] SplitLogLine(string text)
        {
            if (text == null)
                return new string[0];

            return Regex.Split(text, splitLineRegexPattern);
        }

        public int CountQuotedPasswords(string lines)
        {
            if (lines == null)
                return 0;

            MatchCollection matches = Regex.Matches(
                lines,
                quotedPasswordRegexPattern,
                RegexOptions.IgnoreCase
            );

            return matches.Count;
        }

        public string RemoveEndOfLineText(string line)
        {
            if (line == null)
                return "";

            return Regex.Replace(line, endOfLineRegexPattern, "");
        }

        public string[] ListLinesWithPasswords(string[] lines)
        {
            if (lines == null)
                return new string[0];

            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Match match = Regex.Match(
                    lines[i],
                    weakPasswordRegexPattern,
                    RegexOptions.IgnoreCase
                );

                if (match.Success)
                {
                    result[i] = match.Value + ": " + lines[i];
                }
                else
                {
                    result[i] = "--------: " + lines[i];
                }
            }

            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            LogParser parser = new LogParser();

            string logLine = Console.ReadLine();
            Console.WriteLine(parser.IsValidLine(logLine));

            string splitLine = Console.ReadLine();
            string[] parts = parser.SplitLogLine(splitLine);
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }

            string multiLines = "";
            string input;
            while ((input = Console.ReadLine()) != "")
            {
                multiLines += input + "\n";
            }
            Console.WriteLine(parser.CountQuotedPasswords(multiLines));

            string eolLine = Console.ReadLine();
            Console.WriteLine(parser.RemoveEndOfLineText(eolLine));

            int n = int.Parse(Console.ReadLine());
            string[] lines = new string[n];
            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            string[] result = parser.ListLinesWithPasswords(lines);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
