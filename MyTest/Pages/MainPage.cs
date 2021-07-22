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
        private readonly By _headerNewsButton = By.XPath("//div[contains(@class, 'orb-nav-section orb-nav-links orb-nav-focus')]//li[contains(@class, 'orb-nav-newsdotcom')]/a[text() = 'News']");
        private readonly By _headerSportButton = By.XPath("//div[contains(@class, 'orb-nav-section orb-nav-links orb-nav-focus')]//li[contains(@class, 'orb-nav-sport')]/a[text() = 'Sport']");
        private readonly By _headerReelButton = By.XPath("//div[contains(@class, 'orb-nav-section orb-nav-links orb-nav-focus')]//li[contains(@class, 'orb-nav-reeldotcom')]/a[text() = 'Reel']");
        private readonly By _headerWorklifeButton = By.XPath("//div[contains(@class, 'orb-nav-section orb-nav-links orb-nav-focus')]//li[contains(@class, 'orb-nav-worklife')]/a[text() = 'Worklife']");
        private readonly By _headerTravelButton = By.XPath("//div[contains(@class, 'orb-nav-section orb-nav-links orb-nav-focus')]//li[contains(@class, 'orb-nav-traveldotcom')]/a[text() = 'Travel']");
        private readonly By _headerFutureButton = By.XPath("//div[contains(@class, 'orb-nav-section orb-nav-links orb-nav-focus')]//li[contains(@class, 'orb-nav-future')]/a[text() = 'Future']");
        public void OpenStartUrl()
        {
            Navigate(Constants.Site_Url);
        }
        public void OpenNewsPage()
        {
            WaitForDisplayedAndClicable(_headerNewsButton);
            GetWebElement(_headerNewsButton).Click();
        }
        public void OpenSportPage()
        {
            WaitForDisplayedAndClicable(_headerSportButton);
            GetWebElement(_headerSportButton).Click();
        }
        public void OpenReelPage()
        {
            WaitForDisplayedAndClicable(_headerReelButton);
            GetWebElement(_headerReelButton).Click();
        }
        public void OpenWorklifePage()
        {
            WaitForDisplayedAndClicable(_headerWorklifeButton);
            GetWebElement(_headerWorklifeButton).Click();
        }
        public void OpenTravelPage()
        {
            WaitForDisplayedAndClicable(_headerTravelButton);
            GetWebElement(_headerTravelButton).Click();
        }
        public void OpenFuturePage()
        {
            WaitForDisplayedAndClicable(_headerFutureButton);
            GetWebElement(_headerFutureButton).Click();
        }
    }
}
