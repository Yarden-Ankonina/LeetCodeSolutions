using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Arrays
{
    public static class _125_ValidPalindrome
    {
        private static bool isPalindrome(string s)
        {
            bool isPolindrome = true;
            string lowerS = s.ToLower();
            char[] arr = lowerS.Where(c => (char.IsLetterOrDigit(c))).ToArray();
            Console.WriteLine(arr);
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < j)
                {
                    if (arr[i] != arr[j])
                    {
                        isPolindrome = false;
                    }
                }
                j--;
            }
            return isPolindrome;
        }

        public static void Test()
        {
            string s = "A man, a plan, a canal: Panama";
            Console.WriteLine(isPalindrome(s));
        }
    }

   
}
