using OpenQA.Selenium.Chrome;

namespace MidTransTests.DriverClasses
{
    /// <summary>
    /// ChromeDriverManager class extending the abstract WebDriverManager class
    /// Implements CreateWebDriver() method with ChromeDriver() instance
    /// chromedriver.exe is copied to the output folder of the TestSuite
    /// </summary>
    public class ChromeDriverManager : WebDriverManager
    {
        public override void CreateWebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            this.driver = new ChromeDriver(options);
        }
    }
}
