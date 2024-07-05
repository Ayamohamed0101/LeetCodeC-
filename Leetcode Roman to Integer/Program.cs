using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Roman_to_Integer
{
    internal class Program
    {
        //public int RomanToInt(string s);

        static void Main(string[] args)
        {
          //  Console.WriteLine(RomanToInt("MCMXCIV"));
          //  Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("MCMXCIV"));

        }

        public static int RomanToInt(string s)
     {
          Dictionary<string, int> numbers = new Dictionary<string, int>()
          {
            {"I", 1 },
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
          };

            int sum = 0;

            s = s.Replace("IV", "IIII");
            s = s.Replace("IX", "VIIII");
            s = s.Replace("XL", "XXXX");
            s = s.Replace("XC", "LXXXX");
            s = s.Replace("CD", "CCCC");
            s = s.Replace("CM", "DCCCC");
            char[] charArray = s.ToCharArray();
            //"MDCCCCLXXXXIIII" ==> from end ( I*4=4 )+ (X*4= 40) + (50) +(100*4=400) +500+1000 = 1994
            int length = charArray.Length;

            for (int i = length - 1; i >= 0; i--)// i=2 ==>numbers[2] ==> 1
            {
                sum = sum + numbers[charArray[i].ToString()];
            }


            return sum;

          
        }

    }
}
