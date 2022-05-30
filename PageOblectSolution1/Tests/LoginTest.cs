using NUnit.Framework;
using PageOblectSolution1.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageOblectSolution1.Tests
{
    //[Parallelizable(ParallelScope.Children)]
    class LoginTest
    {
        PageProvider _pageProvider;
        [SetUp]
        public void Setup()
        {
            _pageProvider = new PageProvider();

        }
        [Test]
        //public void PositiveLoginTest()
        //{
        //    var loginPageObject = new LoginPageObject(_pageProvider.SetDriver());
        //    //loginPageObject.NavigateToBookStore();
        //    loginPageObject.NavigateToLogin();
        //    loginPageObject.InputLoginData();
        //    string userName = loginPageObject.ReadUsername();
        //    string expectedUserName = loginPageObject.LoggedUsernameToCompare();
        //    Assert.AreEqual(userName, expectedUserName);
        //}
        public void NegativLoginTest()
        {
            var loginPageObject = new LoginPageObject(_pageProvider.SetDriver());
            loginPageObject.NavigateToLogin();
            loginPageObject.InvalidInput();
            string validationMessage = loginPageObject.InvalidInputValidation();
            string ExpectedMessage = loginPageObject.ExpectedValidation();
            Assert.AreEqual(validationMessage, ExpectedMessage);

        }
        [TearDown]
        public void Teardown()
        {
            //_pageProvider.Quit();
        }
    }
}
