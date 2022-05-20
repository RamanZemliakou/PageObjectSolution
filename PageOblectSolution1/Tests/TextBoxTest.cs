using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using PageOblectSolution1.PaegObjects;

namespace PageOblectSolution1.Tests
{
    public class Tests
    {
        //DriverProvider _driverProvider;
        PageProvider _pageProvider;
        
        [SetUp]
        public void Setup()
        {
            //_driverProvider = new DriverProvider();
            _pageProvider = new PageProvider();
        }

        [Test]
        [Parallelizable]
        public void OutputFieldTest()
        {
            var textBoxPage = new TextBoxPageObject(_pageProvider.SetDriver()); //call method GetWebdriver
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
            //_pageProvider.Quit();
        }
    }
}