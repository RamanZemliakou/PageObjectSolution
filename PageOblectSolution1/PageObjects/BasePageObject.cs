using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PageOblectSolution1
{
    class BasePageObject
    {
        protected IWebDriver _webDriver;
        
        public static readonly string url = "https://demoqa.com";
        private readonly By _elementsGroupLocator = By.XPath("//h5[text()='Elements']");
        private readonly By _bookStoreLocator = By.XPath("//h5[text()='Book Store Application']");
        public BasePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void NavigateToElements()
        {
            _webDriver.Navigate().GoToUrl(url);

            IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriver;
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)", "");
            //Actions actions = new Actions(_webDriver);
            //actions.MoveToElement((IWebElement)_bookStoreLocator);
            //actions.Perform();
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(_bookStoreLocator));
            _webDriver.FindElement(_elementsGroupLocator).Click();
        }
        public void NavigateToBookStore()
        {
            _webDriver.Navigate ().GoToUrl(url);
            _webDriver.FindElement(_bookStoreLocator).Click();
        }
    }
}
