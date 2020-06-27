using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MidTransTests.DriverClasses
{
    public abstract class WebDriverManager
    {
        protected IWebDriver driver;
        public abstract void CreateWebDriver();
        public void QuitWebDriver()
        {
            if(driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }

        public IWebDriver GetWebDriver()
        {
            if(driver==null)
            {
                CreateWebDriver();
            }
            return driver;
        }

    }
}
