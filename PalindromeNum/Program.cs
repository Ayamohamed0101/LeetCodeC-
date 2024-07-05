using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PalindromeNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an integer x, return true if x is a   palindrome , and false otherwise.


            Console.WriteLine(IsPalindrome(121)); 
        }
               
            public static bool IsPalindrome(int x)
            {
                if (x < 0)
                {
                    return false;
                }
                long temp = x;
                long reversednum;
                reversednum = 0;
                while (temp != 0)
                {
                    int lastdigit = (int)temp % 10;
                    reversednum = reversednum * 10 + lastdigit;
                    temp = temp / 10;
                }
                return reversednum == x;
            }
        

    }
}
