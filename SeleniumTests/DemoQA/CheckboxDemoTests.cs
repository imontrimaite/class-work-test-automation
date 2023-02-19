
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

        [Test]
        public void MultipleCheckboxes()
        {
            string expectedButtonText = "Uncheck All";

            CheckboxDemoPage.ClickEachofMultipleCheckboxes();
            string actualButtonText = CheckboxDemoPage.GetMultipleCheckboxButtonText();

            Assert.AreEqual(expectedButtonText, actualButtonText);
        }

        [TearDown]
        public void TearDown()
        { 
            Driver.QuitDriver();
        }

    }
}
