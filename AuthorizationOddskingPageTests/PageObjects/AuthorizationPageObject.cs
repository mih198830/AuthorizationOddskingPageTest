using OpenQA.Selenium;

namespace AuthorizationOddskingPageTests.PageObjects
{
    class AuthorizationPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _userNameInputField = By.XPath("//input[@id='Login.username']");
        private readonly By _userPassInputField = By.XPath("//input[@id='Login.password']");
        private readonly By _loginButton = By.XPath("//button[@class='_1uixxswc']");

        public AuthorizationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPagePageObject UserLoginAction(string login, string password)
        {
            _webDriver.FindElement(_userNameInputField).SendKeys(login);
            _webDriver.FindElement(_userPassInputField).SendKeys(password);
            _webDriver.FindElement(_loginButton).Click();
            Thread.Sleep(1000);
            return new MainPagePageObject(_webDriver);
        }
    }
}
