using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PageOblectSolution1.PaegObjects
{
    class ElementsPageObject : BasePageObject
    {
        //private string url = "https://demoqa.com/elements";
        private readonly By _textBoxLocator = By.XPath("//span[text()='Text Box']");

        public ElementsPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }

        public void NavigateToTextBox()
        {
            //_webDriver.Navigate().GoToUrl(url);
            _webDriver.FindElement(_textBoxLocator).Click();
        }
    }
}
