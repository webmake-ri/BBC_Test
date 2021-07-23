using MyTest.Core;
using MyTest.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyTest.Pages
{
    class LoginPage : BasePage
    {
        public readonly By _signInButton = By.XPath("//a[contains(@id, 'idcta-link')]");
        private readonly By _loginInput = By.XPath("//input[contains(@type, 'email')]");
        private readonly By _passwordInput = By.XPath("//input[contains(@type, 'password')]");
        private readonly By _enterButton = By.XPath("//button[contains(@class, 'button button--full-width')]");
        private readonly By _userNameSpan = By.XPath("//span[contains(@id, 'idcta-username')]");
        private readonly By _singOutButton = By.XPath("//span[contains(@class, 'primary-nav__item-text')][text() = 'Sign out']");
        private readonly By _settingsButton = By.XPath("//a[contains(@class, 'button')and(text()='Continue to settings')]");
        private readonly By _settingsUserName = By.XPath("//div[contains(@class, 'field__label')and(text()='Display name')]/preceding-sibling::div[contains(@class, 'field__input')]");
        private readonly By _editUserNameButton = By.XPath("//a[contains(@aria-label, 'Edit Display name')]");
        private readonly By _editUserNameInput = By.XPath("//input[contains(@id, 'displayName-input')]");
        private readonly By _editUserNameSubmit = By.XPath("//button[contains(@type, 'submit')]");
        public readonly By _assertLogin = By.XPath("//div[contains(@aria-live,'assertive')]");
        private readonly By _signUpButton = By.XPath("//a[contains(@data-bbc-result, '/register')]");
        private readonly By _signUpGuardianButton = By.XPath("//a[contains(@data-bbc-result, '/register/details/guardian')]/span");
        private readonly By _signUpOver16Button = By.XPath("//a[contains(@data-bbc-result, '/register/details/age')]/span");
        private readonly By _signUpErrorAgeText = By.XPath("//p[@class = 'text heading u-padding-bottom-single']");
        private readonly By _signUpDayInput = By.XPath("//input[contains(@id, 'day-input')]");
        private readonly By _signUpMonthInput = By.XPath("//input[contains(@id, 'month-input')]");
        private readonly By _signUpYearInput = By.XPath("//input[contains(@id, 'year-input')]");
        public readonly By _signUpErrorDateBirth = By.XPath("//div[contains(@class, 'form-message form-message--error form-message--dateOfBirth')]");
        private readonly By _signUpAcceptButton = By.XPath("//button[contains(@class, 'button button--full-width')]");
        private readonly By _signUpEmailInput = By.XPath("//input[contains(@type, 'email')]");
        private readonly By _signUpPasswordInput = By.XPath("//input[contains(@type, 'password')]");
        private readonly By _signUpAcceptRegisterButton = By.XPath("//button[contains(@class, 'button button--full-width')]");
        public readonly By _signUpErrorText = By.XPath("//div[contains(@aria-live, 'assertive')]");
        


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
            WaitForDisplayedAndClicable(_settingsUserName);
            return GetWebElement(_settingsUserName).Text;
        }
        public void Logout()
        {
            WaitForDisplayedAndClicable(_userNameSpan);
            jsClickOnElement(_userNameSpan);
            WaitForDisplayedAndClicable(_singOutButton);
            jsClickOnElement(_singOutButton);
            WaitForDisplayedAndClicable(_signInButton);
        }
        public void SignUpGuardian()
        {
            WaitForDisplayedAndClicable(_signInButton);
            GetWebElement(_signInButton).Click();
            WaitForDisplayedAndClicable(_signUpButton);
            GetWebElement(_signUpButton).Click();
            jsClickOnElement(_signUpGuardianButton);
        }
        public void SignUpUncorrectDate()
        {
            WaitForDisplayedAndClicable(_signInButton);
            GetWebElement(_signInButton).Click();
            WaitForDisplayedAndClicable(_signUpButton);
            GetWebElement(_signUpButton).Click();
            jsClickOnElement(_signUpOver16Button);

            WaitForDisplayedAndClicable(_signUpDayInput);
            jsClickOnElement(_signUpDayInput);
            GetWebElement(_signUpDayInput).Clear();
            GetWebElement(_signUpDayInput).SendKeys("test");

            WaitForDisplayedAndClicable(_signUpMonthInput);
            jsClickOnElement(_signUpMonthInput);
            GetWebElement(_signUpMonthInput).Clear();
            GetWebElement(_signUpMonthInput).SendKeys("test");

            WaitForDisplayedAndClicable(_signUpYearInput);
            jsClickOnElement(_signUpYearInput);
            GetWebElement(_signUpYearInput).Clear();
            GetWebElement(_signUpYearInput).SendKeys("test");

            WaitForDisplayedAndClicable(_signUpAcceptButton);
            GetWebElement(_signUpAcceptButton).Click();

            WaitForDisplayedAndClicable(_signUpErrorDateBirth);
        }
        public void SignUpEmptyDate()
        {
            WaitForDisplayedAndClicable(_signInButton);
            GetWebElement(_signInButton).Click();
            WaitForDisplayedAndClicable(_signUpButton);
            GetWebElement(_signUpButton).Click();
            jsClickOnElement(_signUpOver16Button);

            WaitForDisplayedAndClicable(_signUpDayInput);
            jsClickOnElement(_signUpDayInput);
            GetWebElement(_signUpDayInput).Clear();

            WaitForDisplayedAndClicable(_signUpMonthInput);
            jsClickOnElement(_signUpMonthInput);
            GetWebElement(_signUpMonthInput).Clear();

            WaitForDisplayedAndClicable(_signUpYearInput);
            jsClickOnElement(_signUpYearInput);
            GetWebElement(_signUpYearInput).Clear();

            WaitForDisplayedAndClicable(_signUpAcceptButton);
            GetWebElement(_signUpAcceptButton).Click();

            WaitForDisplayedAndClicable(_signUpErrorDateBirth);
        }
        public void SignUpCorrectDate()
        {
            WaitForDisplayedAndClicable(_signInButton);
            GetWebElement(_signInButton).Click();
            WaitForDisplayedAndClicable(_signUpButton);
            GetWebElement(_signUpButton).Click();
            jsClickOnElement(_signUpOver16Button);

            WaitForDisplayedAndClicable(_signUpDayInput);
            jsClickOnElement(_signUpDayInput);
            GetWebElement(_signUpDayInput).Clear();
            GetWebElement(_signUpDayInput).SendKeys("01");

            WaitForDisplayedAndClicable(_signUpMonthInput);
            jsClickOnElement(_signUpMonthInput);
            GetWebElement(_signUpMonthInput).Clear();
            GetWebElement(_signUpMonthInput).SendKeys("01");

            WaitForDisplayedAndClicable(_signUpYearInput);
            jsClickOnElement(_signUpYearInput);
            GetWebElement(_signUpYearInput).Clear();
            GetWebElement(_signUpYearInput).SendKeys("2000");

            WaitForDisplayedAndClicable(_signUpAcceptButton);
            GetWebElement(_signUpAcceptButton).Click();

            WaitForDisplayedAndClicable(_signUpEmailInput);
            jsClickOnElement(_signUpEmailInput);
            GetWebElement(_signUpEmailInput).Clear();
            GetWebElement(_signUpEmailInput).SendKeys(Constants.UserEmail);

            WaitForDisplayedAndClicable(_signUpPasswordInput);
            jsClickOnElement(_signUpPasswordInput);
            GetWebElement(_signUpPasswordInput).Clear();
            GetWebElement(_signUpPasswordInput).SendKeys(Constants.UserPassword);

            WaitForDisplayedAndClicable(_signUpAcceptRegisterButton);
            jsClickOnElement(_signUpAcceptRegisterButton);

            WaitForDisplayedAndClicable(_signUpErrorText);
        }
        public void SignUpEmptyEmail()
        {
            WaitForDisplayedAndClicable(_signInButton);
            GetWebElement(_signInButton).Click();
            WaitForDisplayedAndClicable(_signUpButton);
            GetWebElement(_signUpButton).Click();
            jsClickOnElement(_signUpOver16Button);

            WaitForDisplayedAndClicable(_signUpDayInput);
            jsClickOnElement(_signUpDayInput);
            GetWebElement(_signUpDayInput).Clear();
            GetWebElement(_signUpDayInput).SendKeys("01");

            WaitForDisplayedAndClicable(_signUpMonthInput);
            jsClickOnElement(_signUpMonthInput);
            GetWebElement(_signUpMonthInput).Clear();
            GetWebElement(_signUpMonthInput).SendKeys("01");

            WaitForDisplayedAndClicable(_signUpYearInput);
            jsClickOnElement(_signUpYearInput);
            GetWebElement(_signUpYearInput).Clear();
            GetWebElement(_signUpYearInput).SendKeys("2000");

            WaitForDisplayedAndClicable(_signUpAcceptButton);
            GetWebElement(_signUpAcceptButton).Click();

            WaitForDisplayedAndClicable(_signUpEmailInput);
            jsClickOnElement(_signUpEmailInput);
            GetWebElement(_signUpEmailInput).Clear();

            WaitForDisplayedAndClicable(_signUpPasswordInput);
            jsClickOnElement(_signUpPasswordInput);
            GetWebElement(_signUpPasswordInput).Clear();
            GetWebElement(_signUpPasswordInput).SendKeys(Constants.UserPassword);

            WaitForDisplayedAndClicable(_signUpAcceptRegisterButton);
            jsClickOnElement(_signUpAcceptRegisterButton);

            WaitForDisplayedAndClicable(_signUpErrorText);
        }
        public void SignUpEmptyPassword()
        {
            WaitForDisplayedAndClicable(_signInButton);
            GetWebElement(_signInButton).Click();
            WaitForDisplayedAndClicable(_signUpButton);
            GetWebElement(_signUpButton).Click();
            jsClickOnElement(_signUpOver16Button);

            WaitForDisplayedAndClicable(_signUpDayInput);
            jsClickOnElement(_signUpDayInput);
            GetWebElement(_signUpDayInput).Clear();
            GetWebElement(_signUpDayInput).SendKeys("01");

            WaitForDisplayedAndClicable(_signUpMonthInput);
            jsClickOnElement(_signUpMonthInput);
            GetWebElement(_signUpMonthInput).Clear();
            GetWebElement(_signUpMonthInput).SendKeys("01");

            WaitForDisplayedAndClicable(_signUpYearInput);
            jsClickOnElement(_signUpYearInput);
            GetWebElement(_signUpYearInput).Clear();
            GetWebElement(_signUpYearInput).SendKeys("2000");

            WaitForDisplayedAndClicable(_signUpAcceptButton);
            GetWebElement(_signUpAcceptButton).Click();

            WaitForDisplayedAndClicable(_signUpEmailInput);
            jsClickOnElement(_signUpEmailInput);
            GetWebElement(_signUpEmailInput).Clear();
            GetWebElement(_signUpEmailInput).SendKeys(Constants.UserEmail);

            WaitForDisplayedAndClicable(_signUpPasswordInput);
            jsClickOnElement(_signUpPasswordInput);
            GetWebElement(_signUpPasswordInput).Clear();
            

            WaitForDisplayedAndClicable(_signUpAcceptRegisterButton);
            jsClickOnElement(_signUpAcceptRegisterButton);

            WaitForDisplayedAndClicable(_signUpErrorText);
        }
        public string GetErrorAgeMessage()
        {
            WaitForDisplayedAndClicable(_signUpErrorAgeText);
            return GetWebElement(_signUpErrorAgeText).Text;
        }
    }
}

