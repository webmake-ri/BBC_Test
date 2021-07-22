using MyTest.Core;
using MyTest.Pages;
using MyTest.Utils;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace MyTest
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    public class SearchTests
    {
        private MainPage mainPage;
        private SearchPage searchPage;

        [SetUp]
        public void BeforeTest()
        {
            mainPage = new MainPage();
            searchPage = new SearchPage();
        }
        [Test]
        public void SearchEmpty()
        {
            mainPage.OpenStartUrl();
            searchPage.Search(Constants.EmptySearch_Text);
            Assert.AreEqual("https://www.bbc.co.uk/search?q=", Driver.driver.Url);
        }
        [Test]
        public void SearchWithText()
        {
            mainPage.OpenStartUrl();
            searchPage.Search(Constants.Search_Text);
            Assert.AreEqual(Constants.Search_Text, searchPage.GetSearchText());
        }
    }
}
