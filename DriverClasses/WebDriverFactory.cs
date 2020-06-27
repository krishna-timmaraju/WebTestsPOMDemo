
namespace MidTransTests.DriverClasses
{
    /// <summary>
    /// WebDriver Factory class to get a instance of DriverManager for each browser
    /// The type of the browser is read from the Configuration file
    /// Returns the respective browser's DriverManager instance
    /// </summary>
    public class WebDriverFactory
    {
        public static WebDriverManager GetDriverManager(string browser)
        {
            WebDriverManager driverManager;

            switch (browser)
            {
                case "chrome":
                    driverManager = new ChromeDriverManager();
                    break;
                case "firefox":
                    driverManager = new FirefoxDriverManager();
                    break;
                default:
                    driverManager = new ChromeDriverManager();
                    break;
            }
            return driverManager;
            }
        }
    }
