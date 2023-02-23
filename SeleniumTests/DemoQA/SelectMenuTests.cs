
using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class SelectMenuTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            SelectMenuPage.Open();
        }

        [Test]
        public void OneTitleSelection()
        {
            string expectedValue = "Mr.";

            SelectMenuPage.SelectTitle(expectedValue);
            string actuallySelectedTitle = SelectMenuPage.GetSelectedTitle();

            Assert.IsTrue(actuallySelectedTitle.Contains(expectedValue));
        }
    }
}
