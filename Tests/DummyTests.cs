using NUnit.Framework;
using OpenQA.Selenium;

namespace WebTestsPOMDemo.Tests
{
    [TestFixture]
    public class DummyTests : TestBase
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void TestClassStart()
        {
            _driver=Init();
        }

        [OneTimeTearDown]
        public void TestClassEnd()
        {
            QuitBrowser();
        }

        [Test]
        [Ignore("Sample Test to verify framework changes")]
        public void DummyTest()
        {
            NavigateToHome();
        }
    }
}
