using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MidTransTests.Pages
{
    public class OrderSummaryPage
    {
        /// <summary>
        /// Page Object for the Order Summary Frame (Overlay)
        /// </summary>
        IWebDriver _driver;
        public OrderSummaryPage(IWebDriver _driver)
        {
            this._driver = _driver;
            //switch to order summary iframe
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var iframe = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(OrderSummaryFrame));

            _driver.SwitchTo().Frame(iframe);
        }

        //Elements
        private By OrderSummaryFrame = By.Id("snap-midtrans");
        private By ContinueButton = By.ClassName("button-main-content");
        private By ProductName = By.XPath("//span[contains(@class,'item-name')]");

        //Clicking on Continue Button
        public void ClickContinueButton()
        {
            //Explicit Wait for the Continue button to be clickable 
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            var continuebutton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ContinueButton));
            continuebutton.Click();
        }

        // Get the name of the product in the summary page
        public string GetProductName()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ProductName));
            return element.Text;
        }
    }
}
