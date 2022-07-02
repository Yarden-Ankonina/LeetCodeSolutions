using LeetCodeSolutions.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Arrays
{
    public static class ArrayFunctions
    {
        public static void print1DArray<T>(T[] arr)
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            for(int i=0; i< arr.Length; i++)
            {
                res.Append(arr[i] + ", ");
            }
            res.Remove(res.Length-2, 2);
            res.Append("]");
            Console.WriteLine(res.ToString());
        }

    }
}
