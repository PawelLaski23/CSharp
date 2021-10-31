using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Utils
{
   public class DriverFactory
    {

        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                return new ChromeDriver();
            }

            return driver;
        }

    }
}
