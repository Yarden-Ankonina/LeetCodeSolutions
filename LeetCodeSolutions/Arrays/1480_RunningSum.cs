using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Array
{
    static class _1480_RunningSum
    {
        public static int[] RunningSum(int [] nums)
        {
            List<int> runningSum = new List<int>();
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                runningSum.Add(sum);
            }
            return runningSum.ToArray();
        }

        public static void Test()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            ArrayFunctions.print1DArray(RunningSum(nums.ToArray()));
        }
    }
}
