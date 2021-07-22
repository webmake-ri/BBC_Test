using MyTest.Core;
using MyTest.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest.Pages
{
    class NewsPage : BasePage
    {
        private readonly By _newsCoronavirusButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/coronavirus']/span[text() = 'Coronavirus'][1]");
        private readonly By _newsWorldButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/world']/span[text() = 'World'][1]");
        private readonly By _newsUKButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/uk']/span[text() = 'UK'][1]");
        private readonly By _newsBusinessButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/business']/span[text() = 'Business'][1]");
        private readonly By _newsTechnologyButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/technology']/span[text() = 'Tech'][1]");
        private readonly By _newsScienceButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/science_and_environment']/span[text() = 'Science'][1]");
        private readonly By _newsStoriesButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/stories']/span[text() = 'Stories'][1]");
        private readonly By _newsEntertainmentButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/entertainment_and_arts']/span[text() = 'Entertainment & Arts'][1]");
        private readonly By _newsHealthButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/health']/span[text() = 'Health'][1]");
        private readonly By _newsWorldNewsButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/world_radio_and_tv']/span[text() = 'World News TV'][1]");
        private readonly By _newsPicturesButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/in_pictures']/span[text() = 'In Pictures'][1]");
        private readonly By _newsRealityButton = By.XPath("//a[@class= 'nw-o-link'][@href = '/news/reality_check']/span[text() = 'Reality Check'][1]");

        public void NewsCoronavirus()
        {
            WaitForDisplayedAndClicable(_newsCoronavirusButton);
            GetWebElement(_newsCoronavirusButton).Click();
        }
        public void NewsWorld()
        {
            WaitForDisplayedAndClicable(_newsWorldButton);
            GetWebElement(_newsWorldButton).Click();
        }
        public void NewsUK()
        {
            WaitForDisplayedAndClicable(_newsUKButton);
            GetWebElement(_newsUKButton).Click();
        }
        public void NewsBusiness()
        {
            WaitForDisplayedAndClicable(_newsBusinessButton);
            GetWebElement(_newsBusinessButton).Click();
        }
        public void NewsTechnology()
        {
            WaitForDisplayedAndClicable(_newsTechnologyButton);
            GetWebElement(_newsTechnologyButton).Click();
        }
        public void NewsScience()
        {
            WaitForDisplayedAndClicable(_newsScienceButton);
            GetWebElement(_newsScienceButton).Click();
        }
        public void NewsStories()
        {
            WaitForDisplayedAndClicable(_newsStoriesButton);
            GetWebElement(_newsStoriesButton).Click();
        }
        public void NewsEntertainment()
        {
            WaitForDisplayedAndClicable(_newsEntertainmentButton);
            GetWebElement(_newsEntertainmentButton).Click();
        }
        public void NewsHealth()
        {
            WaitForDisplayedAndClicable(_newsHealthButton);
            GetWebElement(_newsHealthButton).Click();
        }
        public void NewsWorldNews()
        {
            WaitForDisplayedAndClicable(_newsWorldNewsButton);
            GetWebElement(_newsWorldNewsButton).Click();
        }
        public void NewsPictures()
        {
            WaitForDisplayedAndClicable(_newsPicturesButton);
            GetWebElement(_newsPicturesButton).Click();
        }
    }
}
