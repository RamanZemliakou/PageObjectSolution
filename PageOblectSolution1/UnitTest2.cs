using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageOblectSolution1.PageObjects;

namespace PageOblectSolution1
{
    internal class UnitTest2
    {
        IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            _webDriver = new DriverProvider().GetDriver();
        }
        [Test]
        public void CheckBoxTest()
        {
            var checkBoxPage = new CheckBoxPageObject(_webDriver);
            checkBoxPage.NavigateToElements();
            checkBoxPage.NavigateToCheckBox();
            checkBoxPage.ExpandListOfCheckboxes();
            //checkBoxPage.SelectOneCheckBox();
        }
        [TearDown]
        public void TearDown()
        {
            //_webDriver.Quit();
        }
    }
}
