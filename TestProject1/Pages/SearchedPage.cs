using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework
{
    public class SearchedPage
    {

        private IWebDriver driver;

        public SearchedPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;

        }

        public string Result(string TagName)
        {
            return driver.FindElement(By.TagName(TagName)).Text;

        }

    }
}


