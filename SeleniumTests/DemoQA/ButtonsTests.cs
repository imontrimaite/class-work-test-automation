using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class ButtonsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            ButtonsPage.Open();
        }

        [Test]
        public void DoubleClick()
        {
            string expectedMessage = "Yo have done a double click";

            ButtonsPage.DoubleClickButton();
            string actualMessage = ButtonsPage.GetDoubleClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
        [Test]
        public void RightClick()
        {
            string expectedMessage = "You have done a right click";

            ButtonsPage.RightClickButton();
            string actualMessage = ButtonsPage.GetRightClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void LeftClick()
        {
            string expectedMessage = "You have done a dynamic click";

            ButtonsPage.LeftClickButton();
            string actualMessage = ButtonsPage.GetLeftClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
