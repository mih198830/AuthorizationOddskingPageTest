using AuthorizationOddskingPageTests.PageObjects;
using AuthorizationOddskingPageTests.Tests;

namespace AuthorizationOddskingPageTests.tests
{
    [TestFixture]
    public class Tests : BaseTest
    {

        [Test]
        public void LoginAsStandartUser()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var mainMenu = new MainPagePageObject(_webDriver);
            mainMenu
                .ContinueCookie()
                .LogIn()
                .UserLoginAction(TestData._Login, TestData._Passwd)
                .MyAccountMenu();

        string accountNumber = mainMenu.GetAccountNumber();

            Assert.That(accountNumber, Is.EqualTo(accountNumber), "Login unsuccessful");
        }
    }
}