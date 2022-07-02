using System;
using System.Collections.Generic;
using LeetCodeSolutions.Array;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //MenuCreator.MenuHandler menuHandler = new MenuCreator.MenuHandler();
            //menuHandler.CreateMenu();
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            int []arr1480 = _1480_RunningSum.RunningSum(nums.ToArray());
            ArrayFunctions.print1DArray(arr1480);
        }
    }
}
