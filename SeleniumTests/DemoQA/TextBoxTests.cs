using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;
using System;

namespace SeleniumTests.DemoQA
{
    internal class TextBoxTests
    {
        [SetUp]

        public void Setup()
        {
            Driver.InitializeDriver();
            TextBoxPage.WindowPosition();
            TextBoxPage.MaximizeWindow();
            TextBoxPage.Open();
            Driver.OpenURL("https://demoqa.com/text-box");
        }

        [Test]
        public void TextBoxTest()
        {
            string expectedFullName = "Ieva Montrimaite";
            string expectedEmail = "montrimaite.ieva@gmail.com";
            string expectedCurrentAddress = "test current address";
            string expectedPermanentAddress = "test permanent address";

            TextBoxPage.InputFullName(expectedFullName);
            TextBoxPage.InputEmail(expectedEmail);
            TextBoxPage.InputCurrentAddress(expectedCurrentAddress);
            TextBoxPage.InputPermanentAddress(expectedPermanentAddress);
            
            TextBoxPage.ScrollWindow("window.scrollBy(0, 200)"); // keliauja i submit button

            TextBoxPage.ClickSubmitButton();

            string actualName = TextBoxPage.GetNameMessage();
            string actualEmail = TextBoxPage.GetEmailMessage();
            string actualCurrentAddress = TextBoxPage.GetCurrentAddressMessage();
            string actualPermanentAddress = TextBoxPage.GetPermanentAddressMessage();

            Assert.IsTrue(actualName.Contains(expectedFullName), $"actual: {actualName}, expected: {expectedFullName}");
            Assert.IsTrue(actualEmail.Contains(expectedEmail), $"actual: {actualEmail}, expected: {expectedEmail}");
            Assert.IsTrue(actualCurrentAddress.Contains(expectedCurrentAddress), $"actual: {actualCurrentAddress}, expected: {expectedCurrentAddress}");
            Assert.IsTrue(actualPermanentAddress.Contains(expectedPermanentAddress), $"actual: {actualPermanentAddress}, expected: {expectedPermanentAddress}");
        }

        [Test] // pakoreguot pagal irasa
        public void InvalidEmailTest()
        {
            string beforeValue = TextBoxPage.GetAttribute("class");

            // Console.WriteLine(TextBoxPage.GetCssValue("border-color"));//tik paziuret, kokia spalva

            TextBoxPage.InputEmail("montrimaite.ievagmail.com");
            TextBoxPage.ClickSubmitButton();

            System.Threading.Thread.Sleep(1000); // kur ir kaip sita deti?

            // Console.WriteLine(TextBoxPage.GetCssValue("border-color")); //tik paziuret, kokia spalva

            string afterValue = TextBoxPage.GetAttribute("class");

            Assert.AreEqual("rgb(255, 0, 0)", TextBoxPage.GetCssValue("border-color"));
            Assert.AreNotEqual(beforeValue, afterValue);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
