using System;
using System.Collections.Generic;
using System.Text;
using MyTest.Core;
using MyTest.Utils;
using OpenQA.Selenium;

namespace MyTest.Pages
{
    class MainPage: BasePage
    {
        private readonly By _footerNewsButton = By.XPath("//div[contains(@class, 'orb-footer-primary-links')]//li[contains(@class, 'orb-nav-newsdotcom')]/a");
        public void OpenStartUrl()
        {
            Navigate(Constants.Site_Url);
        }
        public void OpenNewsPage()
        {
            WaitForDisplayedAndClicable(_footerNewsButton);
            GetWebElement(_footerNewsButton).Click();
        }
    }
}
