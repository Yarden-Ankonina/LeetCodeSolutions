using System;
using System.Text;

namespace Menu
{
    public class MainMenu : MenuItem
    {
        private const string k_MainMenuHeader = "Main Menu";
        private const string k_ExitChoice = "Exit";

        public MainMenu()
            : base(k_MainMenuHeader)
        {
        }

        public void AddActionToMenuItem(MenuItem i_MenuItemToAddActionTo, Action i_ActionToAdd)
        {
            i_MenuItemToAddActionTo.MenuItemSelected += i_ActionToAdd;
        }

        public void AddMenuItemToSubMenu(MenuItem i_SubmenuToAddTheItemTo, MenuItem i_MenuItem)
        {
            i_SubmenuToAddTheItemTo.AddSubMenu(i_MenuItem);
        }

        public void Show()
        {
            r_Ui.ChooseMenuItem(this);
        }

        public override string ToString()
        {
            ShowMenuItems(out StringBuilder stringToPrint);
            stringToPrint.AppendFormat("0 -> {1}{0}", Environment.NewLine, k_ExitChoice);

            return stringToPrint.ToString();
        }
    }
}
