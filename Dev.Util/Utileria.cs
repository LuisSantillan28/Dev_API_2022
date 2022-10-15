using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Util
{
    public static class Utileria
    {
        public static string Base64_Encode(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(bytes);

        }

        public static string Base64_Decode(string str)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(str);
                return Encoding.UTF8.GetString(bytes);
            }
            catch { return ""; }
        }
    }
}
