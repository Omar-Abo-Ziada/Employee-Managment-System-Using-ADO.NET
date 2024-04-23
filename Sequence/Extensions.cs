using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    internal static class Extensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            //List<T> newItems = new List<T>();

            foreach (T item in items)
            {
                if (predicate(item))
                {
                    //newItems.Add(item);
                    yield return item;
                }
            }

            //return newItems;
        }

        public static string RemoveVowels(this string str)
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            string newString = "";

            foreach (char item in str)
            {
                if(!vowels.Contains(item))
                {
                    newString += item;
                }
            }

            return newString;
        }

        public static char GetMiddleChar(this string s)
        {
            return s[s.Length / 2];
        }

        public static bool IsCapital(this char ch)
        {
            return ch >= 'A' && ch <= 'Z';
        }
    }
}
