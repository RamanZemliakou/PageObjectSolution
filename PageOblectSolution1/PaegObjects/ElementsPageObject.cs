using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageOblectSolution1.PaegObjects
{
    class ElementsPageObject : BasePageObject
    {
        protected IWebDriver _webDriver;
        private readonly By _textBoxLocator = By.XPath("//*[@id='item - 0']/span");
        public ElementsPageObject(IWebDriver webDriver) : base(webDriver)
        {

        }
        public void NavigateToTextBox()
        {
            _webDriver.FindElement(_textBoxLocator).Click();
        }
    }
}
