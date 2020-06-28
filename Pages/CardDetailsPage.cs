

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace MidTransTests.Pages
{
    public class CardDetailsPage
    {
        /// <summary>
        /// Page Object for the Card Details Frame
        /// </summary>
        IWebDriver _driver;
        public CardDetailsPage(IWebDriver _driver)
        {
            this._driver = _driver;
            //switch to order summary iframe
            //IWebElement iframe = _driver.FindElement(OrderSummaryFrame);
            //_driver.SwitchTo().Frame(iframe);
        }

        //Elements
        private By OrderSummaryFrame = By.Id("snap-midtrans");
        private By CardNumberTextBox = By.XPath("//*[contains(@name,'cardnumber')]");
        private By CardExpiryDate = By.XPath("//*[contains(@placeholder,'MM / YY')]");
        private By CardCVV = By.XPath("//*[contains(@placeholder,'123')]");
        private By ContinueButton = By.XPath("//a[contains(@class,'button-main-content')]");

        // Method Enter the Credit Card Details
        // Takes 3 parameters need to be passed after reading the values from config file
        public void EnterCardDetails(string CardNumber, string CardExpiry, string CardCVVNumber)
        {
            //Explicit Wait for the Card Number field to be clickable - NOT using Thread.Sleep
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(4));
            var ccnumber = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CardNumberTextBox));
            //Get the Expiry Date and CVV fields
            var ccexpiry = _driver.FindElement(CardExpiryDate);
            var cccvv = _driver.FindElement(CardCVV);

            ccnumber.Click();
            ccnumber.SendKeys(CardNumber);
            ccexpiry.Click();
            ccexpiry.SendKeys(CardExpiry);
            cccvv.Click();
            cccvv.SendKeys(CardCVVNumber);
        }

        //Click on Continue button to proceed to OTP view
        public void ClickContinueButton()
        {
            var cbutton=_driver.FindElement(ContinueButton);
            cbutton.Click();
        }
    }
}
