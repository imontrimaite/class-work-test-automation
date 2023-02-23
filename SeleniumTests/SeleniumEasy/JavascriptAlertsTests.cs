
using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class JavascriptAlertsTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            JavascriptAlertsPage.Open();
        }

        [Test]
        public void TestJavaScriptAlerts()
        {
            string expectedValue = "I am an alert box!";

            JavascriptAlertsPage.OpenSimpleAlert();
            string actualValue = JavascriptAlertsPage.GetAlertText();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
