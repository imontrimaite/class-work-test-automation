

using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class SelectDropdownListTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            SelectDropdownListPage.Open();
        }

        [Test]
        public void SelectDay()
        {
            string expectedDay = "Tuesday";

            SelectDropdownListPage.SelectDay(expectedDay);
            string actualResult = SelectDropdownListPage.GetSelectedDay();

            Assert.IsTrue(actualResult.Contains(expectedDay));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
