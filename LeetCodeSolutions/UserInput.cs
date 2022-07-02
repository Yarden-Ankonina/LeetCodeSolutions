using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class UserInput
    {
        //public static T[] GetArray<T>()
        //{
        //    List<T> array = new List<T>();
        //    Console.WriteLine("Please enter the " + typeof(T) + " Array:");
        //    string input = Console.ReadLine();
        //    char[] charArr = input.ToArray();
        //    foreach (char ch in charArr)
        //    {

        //    }
        //    return array.ToArray();
        //}

        //public static int[] GetArray()
        //{
        //    List<int> array = new List<int>();
        //    Console.WriteLine("Please enter numbers with Enter between them");
        //    string input = Console.ReadLine();
            
        //    return array.ToArray();
        //}

        public static bool GetYesNoInput()
        {
            bool isBoolInput;
            Console.WriteLine("Please Enter Yes / No");
            string input = Console.ReadLine().ToUpper();
            if (input == "YES") isBoolInput = true;
            else if (input == "NO") isBoolInput = false;
            else
            {
                throw new Exception("Input Isn't Correct");
            }
            return isBoolInput;
        }
    }
}
