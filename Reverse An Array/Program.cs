using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_An_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'a', 'b', 'c','D' };
          //  ReverseString(chars);
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
           

        }
        public void reverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                // Swap characters at left and right pointers
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                // Move pointers towards the center
                left++;
                right--;
            }
        }
        //public static void swap(ref int x, ref int y) {

        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap<T>(ref T lhs, ref T rhs)
        //{
        //    T temp = lhs;
        //    lhs = rhs;
        //    rhs = temp;
        //}
        //static void SwapNum(ref int x, ref int y)
        //{

        //    int tempswap = x;
        //    x = y;
        //    y = tempswap;
        //}
        //public static void ReverseString(char[] s)
        //{
        //    for (int i = 0; i < (s.Length)/2; i++)
        //    {

        //        SwapNum( s[ i], s[s.Length - i - 1]);
        //    }
        //}

    }
}
