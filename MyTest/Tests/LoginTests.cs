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
    public class LoginTests
    {
        private MainPage mainPage;
        private LoginPage loginPage;

        [SetUp]
        public void BeforeTest()
        {
            mainPage = new MainPage();
            loginPage = new LoginPage();
        }

        [Test]
        public void CorrectLoginTest()
        {
            mainPage.OpenStartUrl();
            loginPage.Login(Constants.UserEmail, Constants.UserPassword);
            loginPage.SettingsPage();
            Assert.AreEqual(Constants.UserName1, loginPage.GetLoggedUserName());
        }
        [Test]
        public void EmptyPasswordLoginTest()
        {
            mainPage.OpenStartUrl();
            loginPage.Login(Constants.UserEmail, Constants.EmptyPassword);
            Assert.That(loginPage.GetWebElement(loginPage._assertLogin).Displayed, Is.True);
        }
        [Test]
        public void UncorrectPasswordLoginTest()
        {
            mainPage.OpenStartUrl();
            loginPage.Login(Constants.UserEmail, Constants.UncorrectPassword);
            Assert.That(loginPage.GetWebElement(loginPage._assertLogin).Displayed, Is.True);
        }
        [Test]
        public void EmptyEmailLoginTest()
        {
            mainPage.OpenStartUrl();
            loginPage.Login(Constants.EmptyEmail, Constants.UserPassword);
            Assert.That(loginPage.GetWebElement(loginPage._assertLogin).Displayed, Is.True);
        }
        [Test]
        public void UncorrectEmailLoginTest()
        {
            mainPage.OpenStartUrl();
            loginPage.Login(Constants.UncorrectEmail, Constants.UserPassword);
            Assert.That(loginPage.GetWebElement(loginPage._assertLogin).Displayed, Is.True);
        }
        [Test]
        public void LogoutTest()
        {
            mainPage.OpenStartUrl();
            loginPage.Login(Constants.UserEmail, Constants.UserPassword);
            loginPage.Logout();
            Assert.That(loginPage.GetWebElement(loginPage._signInButton).Displayed, Is.True);
        }
        [Test]
        public void OpenSportPageTest()
        {
            mainPage.OpenStartUrl();
            mainPage.OpenSportPage();
            Console.WriteLine("URL страницы: " + Driver.driver.Url);
            Assert.AreEqual(Constants.Sport_Url, Driver.driver.Url);
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