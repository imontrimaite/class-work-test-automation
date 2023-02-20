
using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class CheckboxDemoTestsHomework
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            CheckboxDemoPageHomework.Open();
        }

        [Test]

        public void MultipleCheckboxesSelection()
        {
            CheckboxDemoPageHomework.clickCkeckAllButton();

            Assert.IsTrue(CheckboxDemoPageHomework.GetCheckedOption1Status());
            Assert.IsTrue(CheckboxDemoPageHomework.GetCheckedOption2Status());
            Assert.IsTrue(CheckboxDemoPageHomework.GetCheckedOption3Status());
            Assert.IsTrue(CheckboxDemoPageHomework.GetCheckedOption4Status());
        }
     
        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
