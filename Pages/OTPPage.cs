using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace MidTransTests.Pages
{
    public class OTPPage
    {
        /// <summary>
        /// Page Object for the Bank OTP page
        /// </summary>
        IWebDriver _driver;
        public OTPPage(IWebDriver _driver)
        {
            this._driver = _driver;
            // switch to OTP Transaction iFrame
            //_driver.SwitchTo().DefaultContent();
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            //IWebElement iframe = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//iframe[contains(@src,'mindtrans')]")));
            //_driver.SwitchTo().Frame(iframe);
        }

        // Enter the Bank OTP number in the password field
        // OTP value to be passed as a parameter from the Test Method
        public void EnterOTP(string otp)
        {
            //_driver.SwitchTo().DefaultContent();
            // Switch to the OTP iFrame
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement iframe = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//iframe[contains(@src,'veritrans')]")));
            _driver.SwitchTo().Frame(iframe);

            By OTPPasswordField = By.XPath("//input[contains(@name,'PaRes')]");
            //Explicit Wait for the OTP password field to be clickable - NOT using Thread.Sleep
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            var otpfield = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(OTPPasswordField));         
            otpfield.Click();
            otpfield.SendKeys(otp);
        }

        // Click on the Ok button in OTP page
        public void ClickOkButton()
        {
            By OTPOkButton = By.XPath("//button[contains(@class,'btn-success')]");
            var otpokbutton = _driver.FindElement(OTPOkButton);
            otpokbutton.Click();
        }
    }
}
