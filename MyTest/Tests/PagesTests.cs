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
    public class PageTests
    {
        private MainPage mainPage;
        private LoginPage loginPage;
        private SearchPage searchPage;
        private NewsPage newsPage;

        [SetUp]
        public void BeforeTest()
        {
            mainPage = new MainPage();
            loginPage = new LoginPage();
            searchPage = new SearchPage();
            newsPage = new NewsPage();
        }
        [Test]
        public void NewsPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
        }
        [Test]
        public void SportPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenSportPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.Sport_Url, Driver.driver.Url);
        }
        [Test]
        public void ReelPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenReelPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.Reel_Url, Driver.driver.Url);
        }
        [Test]
        public void WorklifePage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenWorklifePage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.Worklife_Url, Driver.driver.Url);
        }
        [Test]
        public void TravelPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenTravelPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.Travel_Url, Driver.driver.Url);
        }
        [Test]
        public void FuturePage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenFuturePage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.Future_Url, Driver.driver.Url);
        }
        [Test]
        public void NewsCoronavirusPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsCoronavirus();
            Assert.AreEqual(Constants.News_Url + "/coronavirus", Driver.driver.Url);
        }
        [Test]
        public void NewsWorldPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsWorld();
            Assert.AreEqual(Constants.News_Url + "/world", Driver.driver.Url);
        }
        [Test]
        public void NewsUKPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsUK();
            Assert.AreEqual(Constants.News_Url + "/uk", Driver.driver.Url);
        }
        [Test]
        public void NewsBusinessPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsBusiness();
            Assert.AreEqual(Constants.News_Url + "/business", Driver.driver.Url);
        }
        [Test]
        public void NewsTechnologyPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsTechnology();
            Assert.AreEqual(Constants.News_Url + "/technology", Driver.driver.Url);
        }
        [Test]
        public void NewsSciencePage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsScience();
            Assert.AreEqual(Constants.News_Url + "/science_and_environment", Driver.driver.Url);
        }
        [Test]
        public void NewsStoriesPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsStories();
            Assert.AreEqual(Constants.News_Url + "/stories", Driver.driver.Url);
        }
        [Test]
        public void NewsEntertainmentPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsEntertainment();
            Assert.AreEqual(Constants.News_Url + "/entertainment_and_arts", Driver.driver.Url);
        }
        [Test]
        public void NewsHealthPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsHealth();
            Assert.AreEqual(Constants.News_Url + "/health", Driver.driver.Url);
        }
        [Test]
        public void NewsWorldNewsPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsWorldNews();
            Assert.AreEqual(Constants.News_Url + "/world_radio_and_tv", Driver.driver.Url);
        }
        [Test]
        public void NewsPicturesPage()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenNewsPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.News_Url, Driver.driver.Url);
            newsPage.NewsPictures();
            Assert.AreEqual(Constants.News_Url + "/in_pictures", Driver.driver.Url);
        }
        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == TestStatus.Failed)
            {
                Console.WriteLine("Test was failed");
                Driver.MakeScreenShot();
            }
            Driver.Destroy();
        }
    }
}