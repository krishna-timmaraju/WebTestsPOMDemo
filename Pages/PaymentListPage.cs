using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MidTransTests.Pages
{
    public class PaymentListPage
    {
        /// <summary>
        /// Page Object for the Payment Options List (Overlay)
        /// </summary>
        IWebDriver _driver;
        public PaymentListPage(IWebDriver _driver)
        {
            this._driver = _driver;
            //switch to order summary iframe
            //IWebElement iframe = _driver.FindElement(OrderSummaryFrame);
            //_driver.SwitchTo().Frame(iframe);
        }

        //Elements
        private By OrderSummaryFrame = By.Id("snap-midtrans");
        private By CreditCardLink = By.XPath("//a[contains(@href,'credit-card')]");

        //Click on Credit Card button
        public void ClickCreditCard()
        {
            //Explicit Wait for the Continue button to be clickable - NOT using Thread.Sleep
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var ccbutton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CreditCardLink));
            ccbutton.Click();
        }
    }
}
