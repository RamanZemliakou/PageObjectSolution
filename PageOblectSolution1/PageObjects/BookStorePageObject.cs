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
    class BookStorePageObject : BasePageObject
    {
        public static readonly string url = "https://demoqa.com/books";
        private readonly By _loginButton = By.XPath("//button[@id='login']");
        public readonly By _loggedUsername = By.XPath("//label[@id='userName-value']");

        public BookStorePageObject(IWebDriver webDriver) : base(webDriver)
        {
        }

        public void NavigateToLogin()
        {
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(url);
            _webDriver.FindElement(_loginButton).Click();
        }
        public string ReadUsername()
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(_loggedUsername));
            var loggedUserName = _webDriver.FindElement(_loggedUsername).Text;
            return loggedUserName;
        }
        
    }
}
