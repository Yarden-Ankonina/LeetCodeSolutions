using LeetCodeSolutions.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Arrays
{
    public static class _217_ContainsDuplicates
    {
        //O(n^2 Time)
        //O(1 Space)
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

        //Sorting - O(nlogn)
        //path - O(n)
        //Total - O(nlogn + n) = O(nlogn Time)
        // O(1 Space) 
        public static bool ContainsDuplicatesSorting(int[] nums)
        {
            int[] tempInt = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                tempInt[i] = nums[i];
            }
            MergeSort mergeSort = new MergeSort();
            mergeSort.Sort(ref tempInt, 0, nums.Length-1);
            ArrayFunctions.print1DArray(tempInt);

            bool isAtLeastTwice = false;
            for (int i = 0; i < tempInt.Length - 1; i++)
            {
                int j = i + 1;
                if (tempInt[i] == tempInt[j])
                {
                    isAtLeastTwice = true;
                }
            }
            return isAtLeastTwice;

        }

        //insert Hash - O(1)
        //path - O(n)
        //Space - O(n)
        public static bool ContainsDuplicatesHashSet(int[] nums)
        {
            bool isAtLeastTwice = false;

            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashSet.Contains(nums[i]))
                {
                    hashSet.Add(nums[i]);
                }
                else
                {
                    isAtLeastTwice = true;
                    break;
                }
            }

            return isAtLeastTwice;

        }

        public static void TestBruteForce()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 1 };
            Console.WriteLine("Original Array :");
            ArrayFunctions.print1DArray(nums.ToArray());
            Console.WriteLine("Solution:");
            Console.WriteLine(ContainsDuplicatesBruteForce(nums.ToArray()));
        }

        public static void TestSort()
        {
            List<int> nums = new List<int>() { 1, 3 ,2, 7, 3, 4, 5, 6};
            Console.WriteLine("Original Array :");
            ArrayFunctions.print1DArray(nums.ToArray());
            Console.WriteLine("Solution:");
            Console.WriteLine(ContainsDuplicatesSorting(nums.ToArray()));
        }

        public static void TestHash()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 7, 3, 4, 5, 6 };
            Console.WriteLine("Original Array :");
            ArrayFunctions.print1DArray(nums.ToArray());
            Console.WriteLine("Solution:");
            Console.WriteLine(ContainsDuplicatesHashSet(nums.ToArray()));
        }

    }
}
