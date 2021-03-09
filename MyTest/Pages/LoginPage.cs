using MyTest.Core;
using MyTest.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest.Pages
{
    class LoginPage: BasePage
    {
        public readonly By _signInButton = By.XPath("//a[contains(@id, 'idcta-link')]");
        private readonly By _loginInput = By.XPath("//input[contains(@type, 'email')]");
        private readonly By _passwordInput = By.XPath("//input[contains(@type, 'password')]");
        private readonly By _enterButton = By.XPath("//button[contains(@class, 'button button--full-width')]");
        private readonly By _userNameSpan = By.XPath("//span[contains(@id, 'idcta-username')]");
        private readonly By _singOutButton = By.XPath("//span[text() = 'Sign out']");
        private readonly By _settingsButton = By.XPath("//a[contains(@class, 'button')and(text()='Continue to settings')]");
        private readonly By _settingsUserName = By.XPath("//div[contains(@class, 'field__label')and(text()='Display name')]/preceding-sibling::div[contains(@class, 'field__input')]");
        private readonly By _editUserNameButton = By.XPath("//a[contains(@aria-label, 'Edit Display name')]");
        private readonly By _editUserNameInput = By.XPath("//input[contains(@id, 'displayName-input')]");
        private readonly By _editUserNameSubmit = By.XPath("//button[contains(@type, 'submit')]");
        public readonly By _assertLogin = By.XPath("//div[contains(@aria-live,'assertive')]");

        public void Login(string login, string password)
        {
            WaitForDisplayedAndClicable(_signInButton);
            GetWebElement(_signInButton).Click();
            WaitForDisplayedAndClicable(_loginInput);
            GetWebElement(_loginInput).Click();
            GetWebElement(_loginInput).Clear();
            GetWebElement(_loginInput).SendKeys(login);
            WaitForDisplayedAndClicable(_passwordInput);
            GetWebElement(_passwordInput).Click();
            GetWebElement(_passwordInput).Clear();
            GetWebElement(_passwordInput).SendKeys(password);
            WaitForDisplayedAndClicable(_enterButton);
            GetWebElement(_enterButton).Click();
        }
        public void SettingsPage()
        {
            WaitForDisplayedAndClicable(_signInButton);
            GetWebElement(_signInButton).Click();
            WaitForDisplayedAndClicable(_settingsButton);
            GetWebElement(_settingsButton).Click();
        }
        public string GetLoggedUserName()
        {
            WaitForDisplayed(_settingsUserName);
            return GetWebElement(_settingsUserName).Text;
        }
        public void Logout()
        {
            WaitForDisplayedAndClicable(_userNameSpan);
            GetWebElement(_userNameSpan).Click();;
            WaitForDisplayedAndClicable(_singOutButton);
            GetWebElement(_singOutButton).Click();
            WaitForDisplayed(_signInButton);
        }
        public void EditUserDisplayName(string nextUserName)
        {
            WaitForDisplayedAndClicable(_editUserNameButton);
            GetWebElement(_editUserNameButton).Click();
            WaitForDisplayed(_editUserNameInput);
            GetWebElement(_editUserNameInput).Clear();
            GetWebElement(_editUserNameInput).SendKeys(nextUserName);
            WaitForDisplayedAndClicable(_editUserNameSubmit);
            GetWebElement(_editUserNameSubmit).Click();            
        }
    }
}
