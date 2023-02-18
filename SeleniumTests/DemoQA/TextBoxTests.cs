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
            TextBoxPage.Open();
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

        [Test]
        public void InvalidEmailTest()
        {
            string valueInputEmail = "montrimaite.ievagmail.com";

            TextBoxPage.InputEmail(valueInputEmail);
            TextBoxPage.ClickSubmitButton();

            Assert.IsTrue(TextBoxPage.CheckIfEmailErrorIsDisplayed());
            Assert.IsTrue(TextBoxPage.CheckIfemailBorderIsRed());
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
