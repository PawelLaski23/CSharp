using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework
{
    public class LogInPage
    {
        private IWebDriver driver;
        public LogInPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }


        [FindsBy(How = How.Id, Using = "loginEmail")]
        private IWebElement emailInput;

        [FindsBy(How = How.Id, Using = "loginPassword")]
        private IWebElement passwordInput;


        public UserPage logIn(string logIn, string pass)
        {
            emailInput.SendKeys(logIn);
            passwordInput.SendKeys(pass);
            passwordInput.Submit();

            return new UserPage(driver);
        }

    }
}