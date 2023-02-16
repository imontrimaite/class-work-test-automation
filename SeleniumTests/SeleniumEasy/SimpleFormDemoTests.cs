using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class SimpleFormDemoTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.InitializeDriver();
            SimpleFormDemo.Open();
        }

        [Test]
        public void SingleInputField()
        {
            string expectedResult = "Labas";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();

           // sitie veiksmai persirase naudojant POM:
           // inputEnterMessage.SendKeys(expectedResult);
           // buttonShowMessage.Click();
           // string actualResult = spanMessageText.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TwoInputFields()
        {
            string inputA = "5";
            string inputB = "7";
            string expectedResult = "12";

            SimpleFormDemo.EnterInputA(inputA);
            SimpleFormDemo.EnterInputB(inputB);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTwoInputFieldMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
