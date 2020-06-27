using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MidTransTests.Pages
{
    public class HomePage
    {
        IWebDriver _driver;
        public HomePage(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        //Element identifier strings in the Home Page
        private const string BuyNowButtonClass = "btn buy";
        private const string ProductTitleClass = "title";

        //Elements
        private By BuyNowButton = By.ClassName(BuyNowButtonClass);
        private By ProductTitle = By.ClassName(ProductTitleClass);

        //Click on Buy Now button
        public void ClickBuyNow()
        {
            //Explicit Wait for the BuyNow button to be clickable - NOT using Thread.Sleep
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var buynow = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BuyNowButton));
            buynow.Click();
        }

        //Get the Value of the Product Title

    }
}
