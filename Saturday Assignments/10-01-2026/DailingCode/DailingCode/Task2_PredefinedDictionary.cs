using System.Collections.Generic;

namespace DialingCodesApp
{
    public static class Task2_PredefinedDictionary
    {
        public static Dictionary<int, string> GetExistingDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "United States of America");
            dict.Add(55, "Brazil");
            dict.Add(91, "India");
            return dict;
        }
    }
}
