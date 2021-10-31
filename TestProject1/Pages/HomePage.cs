using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Framework
{

    public class HomePage
    {
        private IWebDriver driver;
       


        [FindsBy(How = How.Id, Using = "inputSearch")]
        private IWebElement inputSearch;

        [FindsBy(How = How.XPath, Using = "//div[@id='user-box']/div[1]")]
        private IWebElement logInBox;


        public HomePage(IWebDriver driver)
        {
            
            PageFactory.InitElements(driver, this);
            this.driver = driver;

        }


        public SearchedPage SearchProduct(string product)
        {
            inputSearch.SendKeys(product);
            inputSearch.Submit();

            return new SearchedPage(driver);
        }

        public LogInPage GoToLogInPage()
        {
            logInBox.Click();

            return new LogInPage(driver);
        }

    }

}

