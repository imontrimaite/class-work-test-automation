
using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    internal class CheckboxDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            CheckboxDemoPage.Open();
        }

        [Test]
        public void SingleCheckbox()
        {
            string expectedMessage = "Success - Check box is checked";

            CheckboxDemoPage.ClickSingleCheckbox();
            string actualResult = CheckboxDemoPage.GetSingleCheckboxSuccessMessage();

            Assert.AreEqual(expectedMessage, actualResult);
        }

        [TearDown]
        public void TearDown()
        { 
            Driver.QuitDriver();
        }

    }
}
