using System.Collections.Generic;

namespace DialingCodesApp
{
    public static class Task9_LongestCountryName
    {
        public static string FindLongest(
            Dictionary<int, string> dict)
        {
            string longest = "";

            foreach (KeyValuePair<int, string> item in dict)
            {
                if (item.Value.Length > longest.Length)
                    longest = item.Value;
            }
            return longest;
        }
    }
}
