using System;
using System.Collections.Generic;
using System.Text;
using MyTest.Core;
using MyTest.Utils;


namespace MyTest.Pages
{
    class MainPage: BasePage
    {
        public void OpenStartUrl()
        {
            Navigate(Constants.Site_Url);
        }
    }
}
