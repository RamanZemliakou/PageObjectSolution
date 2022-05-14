using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageOblectSolution1.PaegObjects;

namespace PageOblectSolution1
{
    public class Tests
    {
        IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Navigate().GoToUrl("https://demoqa.com/text-box");
        }

        [Test]
        public void OutputFieldTest()
        {
            var textBoxPage = new TextBoxPageObject(_webDriver);
            textBoxPage.InsertInputData();
            string userName = textBoxPage.ReadData();
                
            var inputName = userName;
            Assert.AreEqual("Name:" + userName, inputName);
        }
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}