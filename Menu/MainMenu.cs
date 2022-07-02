using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuItem
    {
        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        private readonly string r_ReturnTitle;
        private readonly eMenuType r_MenuType;

        public MainMenu(string i_Title, eMenuType i_MenuType)
            : base(i_Title)
        {
            r_ReturnTitle = i_MenuType == eMenuType.MainMenu ? "Exit" : "Back";
            r_MenuType = i_MenuType;
        }

        private enum eChoiceOptions
        {
            BackOrExit = 0,
            FirstOption = 1,
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
        }

        private string ReturnTitle
        {
            get
            {
                return r_ReturnTitle;
            }
        }

        private eMenuType MenuType
        {
            get
            {
                return r_MenuType;
            }
        }

        public void Show()
        {
            bool isExitMenu = false;
            bool isExceptionCaught = false;
            while (!isExitMenu)
            {
                if (isExceptionCaught)
                {
                    isExceptionCaught = false;
                }
                else
                {
                    if (MenuType == eMenuType.MainMenu)
                    {
                        Clear();
                    }

                    printMenu();
                }

                try
                {
                    int choice = getChoiceFromUser();
                    if (choice != (int)eChoiceOptions.BackOrExit)
                    {
                        Clear();
                        clickOnChoice(choice);
                    }
                    else
                    {
                        isExitMenu = true;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid input, please try again");
                    isExceptionCaught = true;
                }
            }

            if (r_MenuType == eMenuType.MainMenu)
            {
                Console.WriteLine("Thank You Bye bye");
            }
        }

        private int getChoiceFromUser()
        {
            Console.WriteLine("Enter your request: {0} to {1} or press '0' to Exit", (int)eChoiceOptions.FirstOption, r_MenuItems.Count);
            int choice = int.Parse(Console.ReadLine());
            isChoiceValid(choice);
            return choice;
        }

        private void printMenu()
        {
            Console.WriteLine(createMenuMsg());
        }

        private string createMenuMsg()
        {
            StringBuilder menu = new StringBuilder();
            int subItemsCounter = 1;

            menu.Append("**" + Title + "**" + Environment.NewLine);
            menu.Append("-----------------------" + Environment.NewLine);

            foreach (MenuItem menuItem in r_MenuItems)
            {
                menu.Append(subItemsCounter + "-> " + menuItem.Title + Environment.NewLine);
                subItemsCounter++;
            }

            menu.Append((int)eChoiceOptions.BackOrExit + "-> " + ReturnTitle + Environment.NewLine);
            return menu.ToString();
        }

        private void isChoiceValid(int i_Choice)
        {
            if (i_Choice < (int)eChoiceOptions.BackOrExit || i_Choice > r_MenuItems.Count)
            {
                throw new Exception();
            }
        }

        private void clickOnChoice(int i_Choice)
        {
            MenuItem menuItem = r_MenuItems[i_Choice - 1];
            if (menuItem is ActiveItem)
            {
                (menuItem as ActiveItem).DoWhenCLicked();
                Console.WriteLine();
            }
            else
            {
                (menuItem as MainMenu).Show();
            }
        }
    }
}