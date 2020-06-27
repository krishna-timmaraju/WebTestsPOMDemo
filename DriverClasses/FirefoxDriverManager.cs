using OpenQA.Selenium.Firefox;


namespace MidTransTests.DriverClasses
{
    public class FirefoxDriverManager : WebDriverManager
    {
        /// <summary>
        /// FirefoxDriverManager class extending the abstract WebDriverManager class
        /// Implements CreateWebDriver() method with FirefoxDriver() instance
        /// geckodriver.exe is copied to the output folder of the TestSuite
        /// </summary>
        public override void CreateWebDriver()
        {
            FirefoxDriver _driver = new FirefoxDriver();
            this.driver = _driver;
        }
    }
}
