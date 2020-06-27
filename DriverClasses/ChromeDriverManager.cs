using OpenQA.Selenium.Chrome;

namespace MidTransTests.DriverClasses
{
    public class ChromeDriverManager : WebDriverManager
    {
        public override void CreateWebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            this.driver = new ChromeDriver(options);
        }
    }
}
