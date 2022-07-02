using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Arrays
{
    public static class _217_ContainsDuplicates
    {
        public static bool ContainsDuplicatesBruteForce(int[] nums)
        {
            bool isAtLeastTwice = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        isAtLeastTwice = true;
                        break;
                    }
                }
            }
            return isAtLeastTwice;

        }

        public static void TestBruteForce()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(ContainsDuplicatesBruteForce(nums.ToArray()));
        }
    }
}
