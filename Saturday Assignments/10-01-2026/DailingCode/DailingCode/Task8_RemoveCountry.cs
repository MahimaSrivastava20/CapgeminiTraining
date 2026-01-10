using System.Collections.Generic;

namespace DialingCodesApp
{
    public static class Task8_RemoveCountry
    {
        public static Dictionary<int, string> Remove(
            Dictionary<int, string> dict, int code)
        {
            if (dict.ContainsKey(code))
                dict.Remove(code);

            return dict;
        }
    }
}
