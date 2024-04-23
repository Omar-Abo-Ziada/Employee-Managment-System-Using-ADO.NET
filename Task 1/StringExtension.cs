using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_1
{
    internal static class StringExtension
    {
        public static string Trim(this string str)
        {
            char[] chars = str.ToCharArray();

            string result = "";

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != ' ')
                    result += chars[i];
            }

            return result;
        }
    }
}
