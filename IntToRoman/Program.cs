using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToRoman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(1994));
        }



        public static string IntToRoman(int num)
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>()
        {


            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }

        };





            var sb = new StringBuilder();

            foreach (var pair in numbers)
            {
                int digit = num / pair.Key;  

                while (digit-- > 0) // 1 , 1 ,0,0,0,1,0 ,0,0,0,0,1
                {
                    sb.Append(numbers[pair.Key]);// M,CM,XC,IV
                }

                num = num % pair.Key; //// 1994 , 994 , 94 ,___,___,___, 9 ,___,4 , ___ ,____,____,____,0
            }

            return sb.ToString();//{MCMXCIV}
        }
    }
}
