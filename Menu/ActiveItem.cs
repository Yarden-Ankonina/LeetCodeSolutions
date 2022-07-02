using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    //$G$ DSN-999 (-3) no need to implement IClickObserver! if you need to implement it then why the function is empty?
    public class ActiveItem : MenuItem, IClickObserver
    {
        private readonly List<IClickObserver> r_ClickObservers = new List<IClickObserver>();

        public ActiveItem(string i_Title)
            : base(i_Title)
        {
            r_ClickObservers.Add(this);
        }

        public void AttachObserver(IClickObserver i_ClickObserver)
        {
            r_ClickObservers.Add(i_ClickObserver);
        }

        public void DoWhenCLicked()
        {
            notifyClickObservers();
        }

        private void notifyClickObservers()
        {
            foreach (IClickObserver observer in r_ClickObservers)
            {
                observer.ReportClicked();
            }
        }

        public void ReportClicked()
        {
        }
    }
}
