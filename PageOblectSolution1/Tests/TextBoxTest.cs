using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using PageOblectSolution1.PaegObjects;
using System.Collections.Generic;

namespace PageOblectSolution1.Tests
{
    [Parallelizable(ParallelScope.Children)] 

    public class Tests
    {
        //protected User user;

        //protected Dictionary<string, string> data;
        //DriverProvider _driverProvider;
        PageProvider _pageProvider;
        
        [SetUp]
        public void Setup()
        {
            
        //_driverProvider = new DriverProvider();
            _pageProvider = new PageProvider();
        }

        [Test]
        
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
        [Test]
        //public void InvalidEmailTest()
        //{
        //    var textBoxPage = new TextBoxPageObject(_pageProvider.SetDriver());
        //    textBoxPage.NavigateToElements();
        //    textBoxPage.NavigateToTextBox();
        //    textBoxPage.EnterInvalidEmail();
        //    textBoxPage.InvalidEmailValidation();
        //    //Assert.That(_pageProvider.Equals(textBoxPage.InvalidEmailValidation), Is.EqualTo(true));
        //}
        [TearDown]
        public void TearDown()
        {
            _pageProvider.Close();
        }
    }
}