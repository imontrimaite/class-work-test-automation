
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

        [Test]
        public void WaitForButtonClassToChange()
        {
            DynamicPropertiesPage.WaitForButtonClassToChange();
        }

        [Test]//paklaust
        public void WaitForButtonTextToBeRed()
        {
            DynamicPropertiesPage.WaitForButtonTextToBeRed();
        }

        [Test]
        public void WaitForButtonTextToBeVisible()
        {
            DynamicPropertiesPage.WaitForButtonTextToBeVisible();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
