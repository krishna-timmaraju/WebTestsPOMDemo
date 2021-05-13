using WebTestsPOMDemo.DriverClasses;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Base Class (and SetupFixture) for all Test Classes
/// Contains:
/// 1. Common data-structures to store the configuration parameters (read from .json file)
/// 2. Browser initialize methods
/// 3. Browser close method
/// </summary>

[SetUpFixture]
public class TestBase
{
    static IWebDriver driver;
    static WebDriverManager driverManager;
    protected static string ApplicationUrl, browser, passccnumber,failccnumber,ccexpiry,cccvv, bankotp;
    static Dictionary<string,string> testdata = new Dictionary<string, string>();

    [OneTimeSetUp]
    public void TestSuiteStart()
    {
        using (StreamReader r = new StreamReader("TestData.json"))
        {
            string json = r.ReadToEnd();
            testdata = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            testdata.TryGetValue("browser",out browser);
            testdata.TryGetValue("ApplicationUrl", out ApplicationUrl);
            testdata.TryGetValue("SuccessCardNumber", out passccnumber);
            testdata.TryGetValue("FailedCardNumber", out failccnumber);
            testdata.TryGetValue("ExpiryDate", out ccexpiry);
            testdata.TryGetValue("CVV", out cccvv);
            testdata.TryGetValue("BankOTP", out bankotp);
        }
    }
    public static IWebDriver Init()
    {
        driverManager = WebDriverFactory.GetDriverManager(browser);
        driver = driverManager.GetWebDriver();
        driver.Manage().Window.Maximize();
        return driver;
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