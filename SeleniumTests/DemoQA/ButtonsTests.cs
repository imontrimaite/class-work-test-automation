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
    }
}
