using Allure.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest.Core
{
    public class Driver
    {
        public static IWebDriver driver;
        public static IWebDriver CurrentDriver
        {
            get { return Driver.GetInstance(); }
        }

        public static EventFiringWebDriver GetInstance()
        {
            if (driver == null)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                driver = new ChromeDriver(options);
            }

            EventFiringWebDriver eventsDriver = new EventFiringWebDriver(driver);
            eventsDriver.Navigated += EventsDriver_Navigated;
            eventsDriver.ScriptExecuting += EventsDriver_Script;
            eventsDriver.ElementClicking += ElementClicking;
            return eventsDriver;
        }

        private static void EventsDriver_Navigated(object sender, WebDriverNavigationEventArgs e)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private static void EventsDriver_Script(object sender, WebDriverScriptEventArgs e)
        {
            _ = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        private static void ElementClicking(object sender, WebElementEventArgs e)
        {
            ScrollToElement(e.Element);
        }
        public static void ScrollToElement(IWebElement e)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(false);", e);
        }
        public static void MakeScreenShot()
        {
            AllureLifecycle.Instance.AddAttachment($"Screenshot [{DateTime.Now:HH:mm:ss}]",
                 "image/png",
                 driver.TakeScreenshot().AsByteArray);
        }
        static public void Destroy()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
                driver = null;
            }
        }
    }
}
