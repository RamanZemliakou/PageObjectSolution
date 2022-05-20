using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageOblectSolution1.PaegObjects
{
    internal class TextBoxPageObject : ElementsPageObject

    {
        private readonly By _fullNameLocator = By.XPath("//*[@id='userName']");
        private readonly By _eMailLocator = By.XPath("//*[@id='userEmail']");
        private readonly By _currentAdressLocator = By.XPath("//*[@id='currentAddress']");
        private readonly By _permanentAddressLocator = By.XPath("//*[@id='permanentAddress']");
        private readonly By _submitButtonLocator = By.XPath("//*[@id='submit']");
        private readonly By _outputFieldLocator = By.XPath("//*[@id='output']");
        private readonly By _outputNameLocator = By.XPath("//*[@id='name']");
        private readonly By _invalidEmailValidation = By.XPath("//*[@class='mr-sm-2 field-error form-control']");

        private readonly string userName = "New User";
        private readonly string userEmail = "mail@mail.com";
        private readonly string currentAddress = "Belarus, Minsk";
        private readonly string permanetAddress = "some other address";
        private readonly string invalidEmail = "qwqwqw";

        public TextBoxPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }
        

        public void InsertInputData()
        {
            _webDriver.FindElement(_fullNameLocator).SendKeys(userName);
            _webDriver.FindElement(_eMailLocator).SendKeys(userEmail);
            _webDriver.FindElement(_currentAdressLocator).SendKeys(currentAddress);
            _webDriver.FindElement(_permanentAddressLocator).SendKeys(permanetAddress);
            _webDriver.FindElement(_submitButtonLocator).Click();

        }
        public string ReadData()
        {
            _webDriver.FindElement(_outputFieldLocator);
            string outputName = _webDriver.FindElement(_outputNameLocator).Text;

            return outputName;
        }

        public void EnterInvalidEmail()
        {
            _webDriver.FindElement(_eMailLocator).SendKeys(invalidEmail);
            _webDriver.FindElement(_submitButtonLocator).Click();
        }

        public void InvalidEmailValidation()
        {
            _webDriver.FindElement(_invalidEmailValidation);
        }

        public string UserNameToCompare()
        {
            string userNameToCompare = userName;
            return userNameToCompare;
        }
    }
}
