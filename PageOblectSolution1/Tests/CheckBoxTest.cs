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
    internal class CheckBoxTest
    {
        IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            _webDriver = new DriverProvider().GetDriver();
        }
        [Test]
        public void CheckBoxSelectionTest()
        {
            var checkBoxPage = new CheckBoxPageObject(_webDriver);
            checkBoxPage.NavigateToElements();
            checkBoxPage.NavigateToCheckBox();
            checkBoxPage.ExpandListOfCheckboxesFirstLayer();
            //checkBoxPage.SelectOneCheckBox();
        }
        [TearDown]
        public void TearDown()
        {
            //_webDriver.Quit();
        }
    }
}
