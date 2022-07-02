using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    public class MainMenu
    {
        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();

        public void Show()
        {
            Console.WriteLine(createMenuMsg());
        }

        private string createMenuMsg()
        {
            StringBuilder menuMsg = new StringBuilder();

            return menuMsg.ToString();
        }
    }
}
