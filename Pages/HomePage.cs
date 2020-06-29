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

        //Elements
        private By BuyNowButton = By.XPath("//a[contains(@class,'buy')]");
        private By ProductTitle = By.XPath("//div[contains(@class,'title')]");

        //Click on Buy Now button
        public void ClickBuyNow()
        {
            //Explicit Wait for the BuyNow button to be clickable 
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var buynow = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BuyNowButton));
            buynow.Click();
        }

        //Get the Value of the Product Title
        public string GetProductTitle()
        {
            //Explicit Wait for the Product Title to be visible 
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var productname = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ProductTitle));
            return (productname.Text);
        }

        // Get the transaction message from the home page
        // WebDriver has to switch to Default Content from the iframe as the message should be displayed on the home page
        public string GetTransMessage()
        {
            //switching to default content, as the iframe is detached
            _driver.SwitchTo().DefaultContent();
            By TransStatus = By.XPath("//div[contains(@class,'trans-success')]//span[1]");
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var transstatus = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(TransStatus));
            return transstatus.Text;
        }
    }
}
