using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using PageOblectSolution1.PaegObjects;

namespace PageOblectSolution1
{
    public class Tests
    {
        IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            _webDriver = new DriverProvider().GetDriver();
        }

        [Test]
        public void OutputFieldTest()
        {
            var textBoxPage = new TextBoxPageObject(_webDriver); //call method GetWebdriver
            textBoxPage.NavigateToElements();
            textBoxPage.NavigateToTextBox();
            textBoxPage.InsertInputData();
            string userNameResult = textBoxPage.ReadData();

            var inputName = textBoxPage.UserNameToCompare();
            Assert.AreEqual("Name:" + inputName, userNameResult);
        }
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}