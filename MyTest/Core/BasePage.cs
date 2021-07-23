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
        public string GetTextByElementValue(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            return Driver.CurrentDriver.FindElement(locator).GetAttribute("value");
        }
        public void WaitForDisplayedAndClicable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            wait.Until((driver) => GetWebElement(locator).Displayed == true);
        }
        public void WaitForEnabled(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(40));
            wait.Until(driver => GetWebElement(locator).Enabled == true);
        }
        public void jsClickOnElement(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            ((IJavaScriptExecutor)Driver.CurrentDriver).ExecuteScript("arguments[0].click();", Driver.CurrentDriver.FindElement(locator));
        }
    }
}
