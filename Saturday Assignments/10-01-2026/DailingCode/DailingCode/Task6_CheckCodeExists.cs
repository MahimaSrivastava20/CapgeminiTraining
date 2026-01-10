using System.Collections.Generic;

namespace DialingCodesApp
{
    public static class Task6_CheckCodeExists
    {
        public static bool Exists(
            Dictionary<int, string> dict, int code)
        {
            return dict.ContainsKey(code);
        }
    }
}
