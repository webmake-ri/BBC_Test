using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest.Core
{ 
    class BasePage
    {
        protected void Navigate(String url)
        {
            Driver.CurrentDriver.Navigate().GoToUrl(url);
        }

        public IWebElement GetWebElement(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            return Driver.CurrentDriver.FindElement(locator);
        }
        public void WaitForClicable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
        public void WaitForDisplayed(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(60));
            wait.Until((driver) => GetWebElement(locator).Displayed == true);
        }
        public void WaitForDisplayedAndClicable(By locator)
        {
            WaitForClicable(locator);
            WaitForDisplayed(locator);
        }
        public void WaitForEnabled(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(40));
            wait.Until(driver => GetWebElement(locator).Enabled == true);
        }
    }
}
