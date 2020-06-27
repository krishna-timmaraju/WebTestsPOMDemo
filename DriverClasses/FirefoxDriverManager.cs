using OpenQA.Selenium.Firefox;


namespace MidTransTests.DriverClasses
{
    public class FirefoxDriverManager : WebDriverManager
    {
        public override void CreateWebDriver()
        {
            FirefoxDriver _driver = new FirefoxDriver();
            this.driver = _driver;
        }
    }
}
