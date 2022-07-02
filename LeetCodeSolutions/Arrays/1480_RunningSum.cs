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
    }
}
