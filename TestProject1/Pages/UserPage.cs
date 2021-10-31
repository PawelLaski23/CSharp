using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework
{
    public class UserPage
    {
        private IWebDriver driver;

        public UserPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.TagName, Using = "h3")]
        private IWebElement h3;

        public IWebElement GetH3()
        {
            return h3;
        }
    }
}