using System.Collections.Generic;

namespace DialingCodesApp
{
    public static class Task5_GetCountryName
    {
        public static string GetCountry(
            Dictionary<int, string> dict, int code)
        {
            if (dict.ContainsKey(code))
                return dict[code];

            return "";
        }
    }
}
