using System.Collections.Generic;

namespace DialingCodesApp
{
    public static class Task3_AddToEmpty
    {
        public static Dictionary<int, string> AddCountry(int code, string name)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(code, name);
            return dict;
        }
    }
}
