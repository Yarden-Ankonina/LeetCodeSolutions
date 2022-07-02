using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    public class MenuHandler
    {
        public MainMenu Menu { get; private  set; }

        public void CreateMenu()
        {
            Menu = new MainMenu();
            Menu.Show();
        }
    }
}
