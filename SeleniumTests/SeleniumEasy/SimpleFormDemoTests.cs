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

           
           // inputEnterMessage.SendKeys(expectedResult);
          //  buttonShowMessage.Click();
           // string actualResult = spanMessageText.Text;

            Assert.AreEqual(expectedResult, actualResult);

            Driver.QuitDriver();
        }
    }
}
