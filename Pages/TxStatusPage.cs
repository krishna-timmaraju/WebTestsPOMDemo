
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebTestsPOMDemo.Pages
{
    public class TxStatusPage
    {
        /// <summary>
        /// Page Object for the Transaction status message page
        /// </summary>
        IWebDriver _driver;
        public TxStatusPage(IWebDriver _driver)
        {
            this._driver = _driver;
            // Implict wait - Need to work on Explicit Wait
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.SwitchTo().ParentFrame();
        }

        // Method to get the transaction status message
        public string GetTxStatusMessage()
        {
            //Explicit Wait for the Transaction Message to appear on the page
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var txstatus = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class,'text-success')//span]")));
            var status =  txstatus.Text;
            return status;
        }

        // Method to get the Failed transaction status message
        public string GetFailedTxStatusMessage()
        {
            //Explicit Wait for the Transaction Message to appear on the page
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var txstatus = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class,'bold')]//span")));
            var status = txstatus.Text;
            return status;
        }
    }
}
