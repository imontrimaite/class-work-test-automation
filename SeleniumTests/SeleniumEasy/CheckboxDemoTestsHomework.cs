
using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;
using System.Collections.Generic;

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

        [Test]
        public void MultipleCheckboxesStatusList()
        {
            CheckboxDemoPageHomework.clickCkeckAllButton();

            Assert.IsTrue(CheckboxDemoPageHomework.CheckIfAllCheckboxesAreSelected());
        }

        //arba

        [Test]
        public void MultipleCheckboxesStatusCheck()
        {
            List<bool> statuses = CheckboxDemoPageHomework.GetStatusOfAllCheckboxes();

            foreach (bool status in statuses)
            { 
                Assert.IsFalse(status);
            }
        }

        [Test]
        public void CheckAllButtonTextChange()
        {
            string expectedAttribute = "Uncheck All";
            string actualResult = CheckboxDemoPageHomework.GetNewCheckAllButtonAttributeValue();

            CheckboxDemoPageHomework.ClickOption1();
            actualResult = CheckboxDemoPageHomework.GetNewCheckAllButtonAttributeValue();
            Assert.AreNotEqual(expectedAttribute, actualResult);

            CheckboxDemoPageHomework.ClickOption2();
            actualResult = CheckboxDemoPageHomework.GetNewCheckAllButtonAttributeValue();
            Assert.AreNotEqual(expectedAttribute, actualResult);

            CheckboxDemoPageHomework.ClickOption3();
            actualResult = CheckboxDemoPageHomework.GetNewCheckAllButtonAttributeValue();
            Assert.AreNotEqual(expectedAttribute, actualResult);

            CheckboxDemoPageHomework.ClickOption4();
            actualResult = CheckboxDemoPageHomework.GetNewCheckAllButtonAttributeValue();
            Assert.AreEqual(expectedAttribute, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
           Driver.QuitDriver();
        }
    }
}
