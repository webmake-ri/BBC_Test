using MyTest.Core;
using MyTest.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest.Pages
{
    class SearchPage: BasePage
    {
        private readonly By _headerSearchInput = By.XPath("//input[@id = 'orb-search-q']");
        private readonly By _searchInput = By.XPath("//input[@id = 'search-input']");
        public void Search(string searchText)
        {
            WaitForDisplayedAndClicable(_headerSearchInput);
            GetWebElement(_headerSearchInput).Click();
            GetWebElement(_headerSearchInput).Clear();
            GetWebElement(_headerSearchInput).SendKeys(searchText+Keys.Enter);
        }
        public string GetSearchText()
        {
            WaitForDisplayedAndClicable(_searchInput);
            GetWebElement(_searchInput).Click();
            return GetTextByElementValue(_searchInput);
        }
    }
}
