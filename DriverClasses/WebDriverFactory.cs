
namespace MidTransTests.DriverClasses
{
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
