using NUnit.Framework;

namespace MidTransTests.Tests
{
    [TestFixture]
    public class SuccessPurchaseTest : TestBase
    {
        [OneTimeSetUp]
        public void TestClassStart()
        {
            Init();
        }
        [OneTimeTearDown]
        public void TestClassEnd()
        {
            QuitBrowser();
        }

        [Test]
        public void VerifyPurchasePillow()
        {

        }

    }
}
