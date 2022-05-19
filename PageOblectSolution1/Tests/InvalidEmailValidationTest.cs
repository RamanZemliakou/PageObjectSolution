using System;
using NUnit.Framework;
using PageOblectSolution1.PaegObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageOblectSolution1.Tests
{
    class InvalidEmailValidationTest
    {
        PageProvider _pageProvider;

        [SetUp]
        public void Setup()
        {
            _pageProvider = new PageProvider();
        }
        [Test]
        public void InvalidEmailTest()
        {
            var textBoxPage = new TextBoxPageObject(_pageProvider.SetDriver());
            textBoxPage.NavigateToElements();
            textBoxPage.NavigateToTextBox();
            textBoxPage.EnterInvalidEmail();

        }
    }
}
