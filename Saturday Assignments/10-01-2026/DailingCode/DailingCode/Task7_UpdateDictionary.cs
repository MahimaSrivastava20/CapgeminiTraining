using System.Collections.Generic;

namespace DialingCodesApp
{
    public static class Task7_UpdateDictionary
    {
        public static Dictionary<int, string> Update(
            Dictionary<int, string> dict, int code, string name)
        {
            if (dict.ContainsKey(code))
                dict[code] = name;

            return dict;
        }
    }
}
