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
        [Parallelizable]
        public void InvalidEmailTest()
        {
            var textBoxPage = new TextBoxPageObject(_pageProvider.SetDriver());
            textBoxPage.NavigateToElements();
            textBoxPage.NavigateToTextBox();
            textBoxPage.EnterInvalidEmail();
            textBoxPage.InvalidEmailValidation();
            Assert.That(_pageProvider.Equals(textBoxPage.InvalidEmailValidation), Is.EqualTo(false));
        }
        [TearDown]
        public void Teardown()
        {
            //_pageProvider.Close();
        }
    }
}
