using LeetCodeSolutions.Arrays;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeSolutions.Arrays
{
    public static class _1_TwoSum
    {
        public static void TestBrute()
        {
            int target = 9;
            List<int> nums = new List<int>() { 4, 7, 11, 5 };
            
            Console.WriteLine("Original Array :");
            ArrayFunctions.print1DArray(nums.ToArray());
            Console.WriteLine("Target :" + target);
            Console.WriteLine("Solution:");
            ArrayFunctions.print1DArray(TwoSumBrute(nums.ToArray(), target));
            
            //int[] res = TwoSumBrutal(arr.ToArray(),target);
            //int[] res = twoSumHash(arr.ToArray(), target);
        }

        public static void TestHash()
        {
            int target = 9;
            List<int> nums = new List<int>() { 4, 7, 11, 5 };

            Console.WriteLine("Original Array :");
            ArrayFunctions.print1DArray(nums.ToArray());
            Console.WriteLine("Target :" + target);
            Console.WriteLine("Solution:");
            ArrayFunctions.print1DArray(twoSumHashOnce(nums.ToArray(), target));

            //int[] res = TwoSumBrutal(arr.ToArray(),target);
            //int[] res = twoSumHash(arr.ToArray(), target);
        }


        private static int[] TwoSumBrute(int[] nums, int target)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < target)
                {
                    for (int j = i+1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            res.Add(i);
                            res.Add(j);
                        }
                    }
                }
            }
            return res.ToArray();
        }

        //Time = O(N^2)
        //Space = O(1)


        private static int[] twoSumHash(int[] i_ToArray, int i_Target)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < i_ToArray.Length; i++)
            {
                dict.Add(i_ToArray[i],i);
            }

            for (int i = 0; i < i_ToArray.Length; i++)
            {
                int complement = i_Target - i_ToArray[i];
                if (dict.ContainsKey(complement) && dict[complement] != i)
                {
                    res.Add(i);
                    res.Add(i_ToArray[i]);
                    break;
                }
            }
            return res.ToArray();

            //Time = O(n)
            //Space = O(n)

        }

        private static int[] twoSumHashOnce(int[] i_ToArray, int i_Target)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < i_ToArray.Length; i++)
            {
                int complement = i_Target - i_ToArray[i];
                if (dict.ContainsKey(complement))
                {
                    res.Add(dict[complement]);
                    res.Add(i);
                    break;
                }
                dict.Add(i_ToArray[i], i);
            }

            return res.ToArray();
        }



        //Time = O(n)
        //Table - O(1)
        //Space = O(n)

    }
    }
   


/*
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
 */

