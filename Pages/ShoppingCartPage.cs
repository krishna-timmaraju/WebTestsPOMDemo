using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebTestsPOMDemo.Pages
{
    public class ShoppingCartPage
    {
        /// <summary>
        /// Page Object for the Shopping Cart Frame (Overlay)
        /// </summary>
        IWebDriver _driver;
        public ShoppingCartPage(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        //Element identifier strings in the Shopping Cart Checkout Page
        private const string CheckOutButtonClass = "cart-checkout";

        //Elements
        private By QuantityLabel = By.XPath("//*[contains(@class, 'label-primary')]");
        private By CheckOutButton = By.ClassName(CheckOutButtonClass);

        
        //Get the Value of the quantity label
        public string GetQuantityValue()
        {
            //Explicit Wait for the BuyNow button to be clickable 
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            var buynow = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(QuantityLabel));
            return buynow.Text;
        }

        //Click on Checkout
        public void ClickCheckout()
        {
            //Explicit Wait for the BuyNow button to be clickable 
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var checkout = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CheckOutButton));
            checkout.Click();
        }
    }
}
