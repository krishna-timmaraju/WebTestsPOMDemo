using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace MidTransTests.Pages
{
    public class OTPPage : TestBase
    {
        /// <summary>
        /// Page Object for the Bank OTP page
        /// </summary>
        IWebDriver _driver;
        public OTPPage(IWebDriver _driver)
        {
            this._driver = _driver;
            //switch to order summary iframe
            //IWebElement iframe = _driver.FindElement(OrderSummaryFrame);
            //_driver.SwitchTo().Frame(iframe);
        }

        //Element identifier strings 
        private const string OrderSummaryIFrameId = "snap-midtrans";

        //Elements
        private By OrderSummaryFrame = By.Id(OrderSummaryIFrameId);
        private By OTPPasswordField = By.Id("PaRes");
        private By OTPOkButton = By.XPath("//button [contains(@class,'btn-success')]");

        //Enter the Bank OTP number in the password field
        public void EnterOTP()
        {
            //Explicit Wait for the Card Number field to be clickable - NOT using Thread.Sleep
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            var otp = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(OTPPasswordField));
            var otpokbutton = _driver.FindElement(OTPOkButton);
            otp.Click();
            otp.SendKeys(bankotp);
            otpokbutton.Click();
        }
    }
}
