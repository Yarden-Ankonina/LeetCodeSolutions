using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Arrays
{
    public class _242_ValidAnagram
    {
        private static bool IsAnagramSort(string s, string t)
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

        private static bool IsAnagramCountLetters(string s, string t)
        {
            bool isAnagram = true;
            if(s.Length != t.Length)
            {
                return false;
            }
            int[] lettersAmount = new int[26];
            for (int i = 0; i < s.Length; i++) 
            {
                lettersAmount[s[i] - 'a']++;
                lettersAmount[t[i] - 'a']--;
            }

            foreach (int num in lettersAmount)
            {
                if(num != 0)
                {
                    isAnagram = false;
                }
            }

            return isAnagram;
        }

        public static void TestSort()
        {
            string s = "anagram", t = "nagaram";
            Console.WriteLine(s + ", " + t);
            Console.WriteLine(IsAnagramSort(s, t));
        }

        public static void TestCountLetters()
        {
            string s = "anagram", t = "nagaram";
            Console.WriteLine(s + ", " + t);
            Console.WriteLine(IsAnagramCountLetters(s, t));
        }
    }
}
