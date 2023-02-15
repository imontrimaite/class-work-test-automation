using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class SimpleFormDemoTests
    {
        [Test]
        public void SingleInputField()
        {
            Driver.InitializeDriver();
            Driver.OpenURL("https://demo.seleniumeasy.com/basic-first-form-demo.html");

            string expectedResult = "Labas";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();

           // sitie veiksmai persirase naudojant POM:
           // inputEnterMessage.SendKeys(expectedResult);
           // buttonShowMessage.Click();
           // string actualResult = spanMessageText.Text;

            Assert.AreEqual(expectedResult, actualResult);

            Driver.QuitDriver();
        }

        [Test]
        public void TwoInputFields()
        {
            Driver.InitializeDriver();
            Driver.OpenURL("https://demo.seleniumeasy.com/basic-first-form-demo.html");

            string inputA = "5";
            string inputB = "7";
            string expectedResult = "12";

            SimpleFormDemo.EnterInputA(inputA);
            SimpleFormDemo.EnterInputB(inputB);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTwoInputFieldMessage();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.QuitDriver();
        }
    }
}
