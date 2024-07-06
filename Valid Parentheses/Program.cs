using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine((int.TryParse("{",out int reslut)));
            Console.WriteLine(IsValid("()[]{}"));

        }
        public static bool IsValid(string s)
        {
            while (s.Contains("()") || s.Contains("{}")||s.Contains("[]"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }
            // '(', ')', '{', '}', '[' , ']'
            return s.Length == 0;

        }
    }
}
