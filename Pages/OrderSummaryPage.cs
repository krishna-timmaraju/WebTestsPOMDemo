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
            IWebElement iframe = _driver.FindElement(OrderSummaryFrame);
            _driver.SwitchTo().Frame(iframe);
        }

        //Element identifier strings 
        private const string OrderSummaryIFrameId = "snap-midtrans";
        private const string ContinueButtonClassName = "button-main-content";

        //Elements
        private By OrderSummaryFrame = By.Id(OrderSummaryIFrameId);
        private By ContinueButton = By.ClassName(ContinueButtonClassName);

        //Clicking on Continue Button
        public void ClickContinueButton()
        {
            //Explicit Wait for the Continue button to be clickable - NOT using Thread.Sleep
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var continuebutton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ContinueButton));
            continuebutton.Click();
        }
    }
}
