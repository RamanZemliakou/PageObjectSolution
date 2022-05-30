using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageOblectSolution1.PageObjects
{
    class LoginPageObject : BookStorePageObject
    {
        private readonly By _userNameField = By.XPath("//input[@placeholder='UserName']");
        private readonly By _passwordField = By.XPath("//input[@placeholder='Password']");
        private readonly By _loginButton = By.XPath("//button[@id='login']");
        private readonly By _invalidValidationMessage = By.XPath("//p[@id='name']");
        private string _username = "qweqwe";
        private string _password = "Test123!";
        private string _invalidUsername = "asdasd";
        private string _invalidPassword = "qweqwe";
        private string _expectedValidationMessage = "Invalid username or password!";
        public LoginPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }
        public void InputLoginData()
        {
            _webDriver.FindElement(_userNameField).SendKeys(_username);
            _webDriver.FindElement(_passwordField).SendKeys(_password);
            _webDriver.FindElement(_loginButton).Click();
        }
        public void InvalidInput()
        {
            _webDriver.FindElement(_userNameField).SendKeys(_invalidUsername);
            _webDriver.FindElement(_passwordField).SendKeys(_invalidPassword);
            _webDriver.FindElement(_loginButton).Click();
        }
        public string LoggedUsernameToCompare()
        {
            string loggedUsernameToCompare = _username;
            return loggedUsernameToCompare;
        }
        public string InvalidInputValidation()
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(_invalidValidationMessage));
            string invalidInputValidationMessage = _webDriver.FindElement(_invalidValidationMessage).Text;
            return invalidInputValidationMessage;
        }
        public string ExpectedValidation()
        {
            string expectedValidation = _expectedValidationMessage;
            return expectedValidation;
        }
    }
}
