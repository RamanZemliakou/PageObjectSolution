using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        public BasePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void NavigateToElements()
        {
            _webDriver.Navigate().GoToUrl(url);
            _webDriver.FindElement(_elementsGroupLocator).Click();
        }
    }
}
