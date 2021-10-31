using Framework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Framework
{
    public class BaseTest
    {

        protected IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = DriverFactory.GetDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.taniaksiazka.pl/");
        }

        [TearDown]
        public void SystemDown()
        {
            driver.Quit();
        }

    }
}
