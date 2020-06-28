
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MidTransTests.Pages
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
        }

        //Elements
        private By TxStatus = By.XPath("//div[contains(@class,'text')]");

        // Method to get the transaction status message
        public string GetTxStatusMessage()
        {
            //Explicit Wait for the Transaction Message to appear on the page
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var txstatus = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(TxStatus));
            var status =  txstatus.Text;
            return status;
        }
    }
}
