using MidTransTests.DriverClasses;
using OpenQA.Selenium;
using System.Configuration;

public class TestBase
{
    static IWebDriver driver;
    static WebDriverManager driverManager;
    static string ApplicationUrl = ConfigurationManager.AppSettings["ApplicationUrl"];
    static string browser = ConfigurationManager.AppSettings["browser"];
    public static IWebDriver Init()
    {
        driverManager = WebDriverFactory.GetDriverManager(browser);
        driver = driverManager.GetWebDriver();
        driver.Manage().Window.Maximize();
        return driver;
    }
    public static string Title
    {
        get { return driver.Title; }
    }
  
    public static void NavigateToHome()
    {
        driver.Navigate().GoToUrl(ApplicationUrl);
    }
    public static void QuitBrowser()
    {
        driver.Quit();
    }
}