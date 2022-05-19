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
        DriverProvider _driverProvider;

        [SetUp]
        public void Setup()
        {
            _driverProvider = new DriverProvider();
        }
        [Test]
        public void CheckBoxSelectionTest()
        {
            var checkBoxPage = new CheckBoxPageObject(_driverProvider.GetDriver());
            checkBoxPage.NavigateToElements();
            checkBoxPage.NavigateToCheckBox();
            checkBoxPage.ExpandListOfCheckboxesFirstLayer();
            //checkBoxPage.SelectOneCheckBox();
        }
        [TearDown]
        public void TearDown()
        {
            _driverProvider.Quit();
        }
    }
}
