using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Arrays
{
    public class _242_ValidAnagram
    {
        private static bool IsAnagram(string s, string t)
        {
            bool isAnagram = true;
            if(s.Length == t.Length)
            {
                char[] s_Array = s.ToArray();
                char[] t_Array = t.ToArray();

                Array.Sort(s_Array);
                Array.Sort(t_Array);

                for(int i = 0; i < s.Length; i++)
                {
                    if (s_Array[i] != t_Array[i])
                    {
                        isAnagram = false;
                    }
                }
            }
            else
            {
                isAnagram = false;
            }

            return isAnagram;
        }

        public static void Test()
        {
            string s = "anagram", t = "nagaram";
            Console.WriteLine(s + ", " + t);
            Console.WriteLine(IsAnagram(s, t));
        }
    }
}
