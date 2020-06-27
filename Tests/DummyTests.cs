using NUnit.Framework;
using OpenQA.Selenium;

namespace MidTransTests.Tests
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
        public void DummyTest()
        {
            NavigateToHome();
        }
    }
}
