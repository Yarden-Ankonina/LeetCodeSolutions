using LeetCodeSolutions.Arrays;
using Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class MenuCreator
    {
        public void DisplayMenu()
        {
            MainMenu menu = new MainMenu();

            MenuItem problems = new MenuItem("Problems");

            MenuItem arraysAndHashing = new MenuItem("Arrays & Hashing");

            MenuItem twoSum = new MenuItem("1_TwoSum");
            MenuItem twoSumBrute = new MenuItem("1_TwoSum - Brute", _1_TwoSum.TestBrute);
            MenuItem twoSumHash = new MenuItem("1_TwoSum - Hash", _1_TwoSum.TestHash);
            twoSum.AddSubMenu(twoSumBrute, twoSumHash);

            MenuItem validPalindrome = new MenuItem("125_ValidPalindrome", _125_ValidPalindrome.Test);

            MenuItem containDuplicates = new MenuItem("217_ContainsDuplicates");
            MenuItem containDuplicateBrute = new MenuItem("217_ContainsDuplicates - Brute", _217_ContainsDuplicates.TestBruteForce);
            MenuItem containDuplicateSorting = new MenuItem("217_ContainsDuplicates - Sort", _217_ContainsDuplicates.TestSort);
            MenuItem containDuplicateHash = new MenuItem("217_ContainsDuplicates - Hashset", _217_ContainsDuplicates.TestHash);
            containDuplicates.AddSubMenu(containDuplicateBrute, containDuplicateSorting, containDuplicateHash);

            MenuItem validAnagram = new MenuItem("242_ValidAnagram");
            MenuItem validAnagramSort = new MenuItem("242_ValidAnagram - Sort", _242_ValidAnagram.TestSort);
            MenuItem validAnagramCount = new MenuItem("242_ValidAnagram - Letter Count", _242_ValidAnagram.TestCountLetters);
            validAnagram.AddSubMenu(validAnagramSort, validAnagramCount);
            MenuItem runningSum = new MenuItem("1480_RunningSum", _1480_RunningSum.Test);


            arraysAndHashing.AddSubMenu(twoSum, validPalindrome, containDuplicates,
                validAnagram, runningSum);

            //MenuItem settings = new MenuItem("Settings");
            //MenuItem changeDefaultIntArray = new MenuItem("Change Default Int Array?", MenuSettings.changeDefaultIntArray);
            //settings.AddSubMenu(changeDefaultIntArray);

            problems.AddSubMenu(arraysAndHashing);
            menu.AddSubMenu(problems/*setting*/);
            menu.Show();
        }

        public static void CountUpperCase()
        {
            int counterOfUpperCase = 0;

            Console.WriteLine("Please enter your sentence:");
            string input = Console.ReadLine();
            if (input != null)
            {
                foreach (char ch in input)
                {
                    if (char.IsUpper(ch))
                    {
                        counterOfUpperCase++;
                    }
                }
            }

            Console.WriteLine("There are {1} capitals is your sentence{0}", Environment.NewLine, counterOfUpperCase);
        }
    }
}
