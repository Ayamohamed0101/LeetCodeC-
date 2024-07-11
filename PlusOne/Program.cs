using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr = { 9, 9, 9 };
            Console.WriteLine(PlusOne(arr));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        public  static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;

            return newNumber;
        }
        //public  static int[] PlusOne(int[] digits)
        //{
        //    int lastdigit = digits.Length-1;
        //    if (digits[lastdigit]!=9)
        //    {
        //        digits[lastdigit]++; //increment
        //        return digits;
        //    }

        //    while (digits[lastdigit]==9)
        //    {
        //        if (digits[lastdigit-1]==9)
        //        {
        //            digits[lastdigit] = 0;
        //            digits[lastdigit-1] = 0;
        //            digits[lastdigit - 2] ++;

        //            return digits;
        //        }
        //        digits[lastdigit] = 0;
        //        digits[lastdigit - 1] ++;
        //        return digits;
        //    }
        //    return digits;
        //}
    }
}
