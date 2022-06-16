using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AuthorizationOddskingPageTests
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;
        [OneTimeSetUp]
        protected void DoBeforeAllTheTests()
        {
            _webDriver = new ChromeDriver();
        }

        [TearDown]
        protected void DoAfterEach()
        {
            _webDriver.Quit();
        }
        [SetUp]
        protected void DoBeforeEach()
        {
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Navigate().GoToUrl(TestSettings.HostPrefix);
            _webDriver.Manage().Window.Maximize();
        }
    }
}
