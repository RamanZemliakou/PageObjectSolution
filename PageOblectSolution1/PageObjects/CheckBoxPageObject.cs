using OpenQA.Selenium;
using PageOblectSolution1.PaegObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageOblectSolution1.PageObjects
{
    internal class CheckBoxPageObject : ElementsPageObject
    {
        private readonly By _expandListOfCheckBoxes = By.XPath("//*[@id='tree-node']");
        private readonly By _commandsCheckBoxLocator = By.XPath("//span[text()='Commands']");
        public CheckBoxPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }
        public void ExpandListOfCheckboxesFirstLayer()
        {
            _webDriver.FindElement(_expandListOfCheckBoxes).Click();
        }
        public void SelectOneCheckBox()
        {
            _webDriver.FindElement(_commandsCheckBoxLocator).Click();
        }
    }
}
