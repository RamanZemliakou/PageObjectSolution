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
        private readonly By _textBoxLocator = By.XPath("//span[text()='Text Box']");
        private readonly By _checkBoxLocator = By.XPath("//span[text()='Check Box']");
        private readonly By _radioButtonLocator = By.XPath("//span[text()='Radio Button']");

        public ElementsPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }

        public void NavigateToTextBox()
        {
            _webDriver.FindElement(_textBoxLocator).Click();
        }
        public void NavigateToCheckBox()
        {
            _webDriver.FindElement(_checkBoxLocator).Click();
        }
        public void NavigateToRadioButton()
        {
            _webDriver.FindElement(_radioButtonLocator).Click();
        }
    }
}
