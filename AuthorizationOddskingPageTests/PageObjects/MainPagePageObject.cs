using OpenQA.Selenium;

namespace AuthorizationOddskingPageTests.PageObjects
{
    internal class MainPagePageObject
    {
        private IWebDriver _webDriver;

        private readonly By _logInButton = By.XPath("//button[@class='_1keyjde']");
        private readonly By _myAccount = By.XPath("//button[@class='_i6zqtr7']");
        private readonly By _coockies = By.XPath("//button[@class='_nax69fb']");
        private readonly By _accountNumber = By.XPath("//span[@data-actionable='MyAccount.Menu.accountNumber']");

        public MainPagePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPagePageObject ContinueCookie()
        {
            _webDriver.FindElement(_coockies).Click();
            return this;
        }

        public AuthorizationPageObject LogIn()
        {
            _webDriver.FindElement(_logInButton).Click();
            return new AuthorizationPageObject(_webDriver);
        }

        public MainPagePageObject MyAccountMenu()
        {
            Thread.Sleep(700);
            _webDriver.FindElement(_myAccount).Click();
            Thread.Sleep(700);
            return new MainPagePageObject(_webDriver);
        }

       public string GetAccountNumber()
       {
            Thread.Sleep(400);
            string accountNumber = _webDriver.FindElement(_accountNumber).Text;
            return accountNumber;
        }
    }
}
