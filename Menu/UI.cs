using System;

namespace Menu
{
    public class UI
    {
        private const int k_BackOrExitChoice = 0;

        internal void ChooseMenuItem(MenuItem i_MenuItem)
        {
            Console.WriteLine(i_MenuItem);
            getChoiceFromUser(i_MenuItem, out int userChoice);
            if (userChoice == k_BackOrExitChoice)
            {
                showMainMenu(i_MenuItem);
            }
            else
            {
                if (i_MenuItem.SubmenuItems[userChoice - 1].IsSubmenu())
                {
                    showSubmenu(i_MenuItem, userChoice);
                }
                else
                {
                    executeSelectedAction(i_MenuItem, userChoice);
                }
            }
        }

        private void getChoiceFromUser(MenuItem i_MenuItem, out int o_NumricInput)
        {
            o_NumricInput = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine("Enter your request:");
                bool isParsed = int.TryParse(Console.ReadLine(), out int input);

                if (isParsed && input >= 0 && input <= i_MenuItem.SubmenuItems.Count)
                {
                    o_NumricInput = input;
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again{0}", Environment.NewLine);
                }
            }
        }

        private void showMainMenu(MenuItem i_MenuItem)
        {
            if (i_MenuItem.MainMenu != null)
            {
                Console.Clear();
                i_MenuItem.MainMenu.ShowMenuAndGetUserInput();
            }
        }

        private void showSubmenu(MenuItem i_MenuItem, int i_UserChoice)
        {
            Console.Clear();
            i_MenuItem.SubmenuItems[i_UserChoice - 1].ShowMenuAndGetUserInput();
        }

        private void executeSelectedAction(MenuItem i_MenuItem, int i_UserChoice)
        {
            Console.Clear();
            i_MenuItem.SubmenuItems[i_UserChoice - 1].OnMenuItemSelected();
            Console.WriteLine(Environment.NewLine);
            i_MenuItem.ShowMenuAndGetUserInput();
        }
    }
}
