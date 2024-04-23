using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal static class Int32Extension //: IComparable
    {

        public static int Reverse(this int number)
        {
            string strNum = number.ToString();

            char[] chars = strNum.ToCharArray();

            Array.Reverse(chars);

            string reversedStrNum = new string(chars);

            //Console.WriteLine($"reversed str : {reversedStrNum}");

            int reversedNum = int.Parse(reversedStrNum);

            //Console.WriteLine($"reversed int : {reversedNum}");

            return reversedNum;
        }

        public static int NumberOfDigits(this int number)
        {
            string strNum = number.ToString();

            return strNum.Length;
        }

        public static int GetMaxInt(this IEnumerable<int> nums)
        {
            int MaxNum = int.MinValue;

            foreach (int num in nums)
            {
                if (num > MaxNum)
                    MaxNum = num;
            }

            return MaxNum;
        }

        public static T GetMax<T>(this IEnumerable<T> items) where T : IComparable<T>
        {
            T maxValue = default(T);

            foreach (T item in items)
            {
                if (item.CompareTo(maxValue) > 0)
                    maxValue = item;

                //if (item.Equals(maxValue) > 0)
                //    maxValue = item;
            }

            return maxValue;
        }

        //public int CompareTo(object? obj)
        //{
        //    throw new NotImplementedException();
        //}

    }
}


