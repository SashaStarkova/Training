using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.Classes
{
    public class PagesNavigate
    {
        private Pages.StartPage startPage;
        private Pages.MainPage mainPage;

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
    }
}
