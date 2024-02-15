using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class Program
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                int[] ar = new int[2];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            ar[0] = i;
                            ar[1] = j;
                            return ar;
                        }
                    }
                }
                return ar;
            }
        }
        static void Main(string[] args)
        {

            Solution solution = new Solution();
            int[] myNum = { 10, 20, 30, 40 };
            for (int i = 0; i < myNum.Length ; i++)
            {
               solution.TwoSum(myNum, 30);
            }
        }
           
    }
}
