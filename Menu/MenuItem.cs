using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class MenuItem
    {
        private const string k_BackChoice = "Back";
        private readonly string r_MenuHeader;
        private readonly List<MenuItem> r_SubmenuItems;
        private MenuItem m_MenuFather;

        public event Action MenuItemSelected;

        protected readonly UI r_Ui = new UI();

        public string MenuHeader
        {
            get
            {
                return r_MenuHeader;
            }
        }

        public List<MenuItem> SubmenuItems
        {
            get
            {
                return r_SubmenuItems;
            }
        }

        public MenuItem MainMenu
        {
            get
            {
                return m_MenuFather;
            }
        }

        public MenuItem(string i_MenuHeader)
        {
            r_MenuHeader = i_MenuHeader;
            r_SubmenuItems = new List<MenuItem>();
        }

        public MenuItem(string i_MenuHeader, params Action[] i_MenuItemSelectedAction)
        {
            r_MenuHeader = i_MenuHeader;
            r_SubmenuItems = new List<MenuItem>();

            foreach (Action action in i_MenuItemSelectedAction)
            {
                MenuItemSelected += action;
            }
        }

        public MenuItem(string i_MenuHeader, params MenuItem[] i_SubmenuItem)
        {
            r_MenuHeader = i_MenuHeader;
            r_SubmenuItems = new List<MenuItem>();

            AddSubMenu(i_SubmenuItem);
        }

        public void AddSubMenu(params MenuItem[] i_MenuItems)
        {
            foreach (MenuItem item in i_MenuItems)
            {
                item.m_MenuFather = this;
                r_SubmenuItems.Add(item);
            }
        }

        protected internal void OnMenuItemSelected()
        {
            if (MenuItemSelected != null)
            {
                MenuItemSelected.Invoke();
            }
        }

        public void ShowMenuAndGetUserInput()
        {
            r_Ui.ChooseMenuItem(this);
        }

        public bool IsSubmenu()
        {
            return MenuItemSelected == null;
        }

        protected void ShowMenuItems(out StringBuilder o_StringToPrint)
        {
            o_StringToPrint = new StringBuilder();
            int i = 1;

            // move To UI
            o_StringToPrint.Append("**" + r_MenuHeader + "**" + Environment.NewLine);
            o_StringToPrint.AppendFormat("--------------------{0}", Environment.NewLine);
            foreach (MenuItem item in r_SubmenuItems)
            {
                o_StringToPrint.AppendFormat("{1} -> {2}{0}", Environment.NewLine, i++, item.r_MenuHeader);
            }

            o_StringToPrint.AppendFormat("--------------------{0}", Environment.NewLine);
        }

        public override string ToString()
        {
            ShowMenuItems(out StringBuilder stringToPrint);
            stringToPrint.AppendFormat("0 -> {1}{0}", Environment.NewLine, k_BackChoice);

            return stringToPrint.ToString();
        }
    }
}
