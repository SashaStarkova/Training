using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.Classes
{
    public class PagesNavigate
    {
        private Pages.StartPage startPage;
        private Pages.MainPage mainPage;
        private Pages.CartWindow cartWindow;

        public Pages.StartPage IsStartPageExist()
        {
            if (startPage != null)
            {
                return startPage;
            }
            return startPage = new Pages.StartPage();
        }

        public Pages.MainPage IsMainPageExist()
        {
            if (startPage != null)
            {
                return mainPage;
            }
            return mainPage = new Pages.MainPage();
        }

        public Pages.CartWindow IsCartWindowExist(ObservableCollection<Database.Product> products)
        {
            if (cartWindow != null)
            {
                return cartWindow;
            }
            return cartWindow = new Pages.CartWindow(products);
        }
    }
}
