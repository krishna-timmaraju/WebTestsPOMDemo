using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MidTransTests.DriverClasses
{
    /// <summary>
    /// Abstract WebDriveManager class to define a contract for the brower specific WebDriver classes
    /// Contains CreateWebDriver and QuitWebDriver Methods
    /// </summary>
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
