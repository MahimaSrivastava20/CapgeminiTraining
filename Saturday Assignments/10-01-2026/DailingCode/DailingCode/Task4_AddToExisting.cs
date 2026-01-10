using System.Collections.Generic;

namespace DialingCodesApp
{
    public static class Task4_AddToExisting
    {
        public static Dictionary<int, string> AddCountry(
            Dictionary<int, string> dict, int code, string name)
        {
            if (dict.ContainsKey(code))
                dict[code] = name;
            else
                dict.Add(code, name);

            return dict;
        }
    }
}
