using NUnit.Framework;
using OpenQA.Selenium;

namespace Framework
{
    public class LogInTest : BaseTest
    {

        [Test]
        public void LogIn()
        {
            IWebElement h3 = new HomePage(driver)
             .GoToLogInPage()
             .logIn("pawel.laski@arete33.pl", "Yamahalove23")
             .GetH3();

            Assert.AreEqual("Twoje konto", h3.Text);

        }
    }
}
