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

            MenuItem arrays = new MenuItem("Arrays");
            MenuItem twoSumBrute = new MenuItem("1_TwoSum", _1_TwoSum.TestBrute);

            MenuItem runningSum = new MenuItem("1480_RunningSum", _1480_RunningSum.Test);
            MenuItem containDuplicate = new MenuItem("217_ContainsDuplicates - Brute", _217_ContainsDuplicates.TestBruteForce);
            MenuItem containDuplicateSorting = new MenuItem("217_ContainsDuplicates - Sort", _217_ContainsDuplicates.TestSort);


            MenuItem hash = new MenuItem("Hash");
            MenuItem twoSumHash = new MenuItem("1_TwoSum", _1_TwoSum.TestHash);
            MenuItem containDuplicateHash = new MenuItem("217_ContainsDuplicates - Hashset", _217_ContainsDuplicates.TestHash);


            //MenuItem settings = new MenuItem("Settings");
            //MenuItem changeDefaultIntArray = new MenuItem("Change Default Int Array?", MenuSettings.changeDefaultIntArray);
            //settings.AddSubMenu(changeDefaultIntArray);

            arrays.AddSubMenu(twoSumBrute, runningSum,
                containDuplicate, containDuplicateSorting);

            hash.AddSubMenu(twoSumHash, containDuplicateHash);

            problems.AddSubMenu(arrays, hash);
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
