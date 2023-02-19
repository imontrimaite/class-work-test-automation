
using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    internal class DynamicPropertiesTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            DynamicPropertiesPage.Open();
        }
        [Test]
        public void WaitForButtonToBeClickable()
        {
            Assert.IsTrue(DynamicPropertiesPage.WaitForButtonToBeClickable());
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
