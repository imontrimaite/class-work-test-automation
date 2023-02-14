using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace SeleniumTestsWithoutPOM3
{
    internal class homework2
    {
        // nepavykes
        [Test]
        public void TextBoxTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Position = new System.Drawing.Point(2000, 1);
            driver.Manage().Window.Maximize();

            driver.Url = "https://demoqa.com/text-box";

            string expectedFullName = "Ieva Montrimaite";
            string expectedEmail = "montrimaite.ieva@gmail.com";
            string expectedCurrentAddress = "2436 N 48th St #101, Lincoln, New Hampshire";
            string expectedPermanentAddress = "8602 SW State Road 200, Ocala, Florida";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            inputFullName.SendKeys(expectedFullName);
            inputEmail.SendKeys(expectedEmail);
            inputCurrentAddress.SendKeys(expectedCurrentAddress);
            inputPermanentAddress.SendKeys(expectedPermanentAddress);
            
            // driver.ExecuteJavaScript()
            buttonSubmit.Click();

            IWebElement spanMessageName = driver.FindElement(By.XPath("//*[@id='name']"));
            IWebElement spanMessageEmail = driver.FindElement(By.XPath("//*[@id='email']"));
            IWebElement spanMessageCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement spanMessagePermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));

            string actualName = spanMessageName.Text;
            string actualEmail = spanMessageEmail.Text;
            string actualCurrentAddress = spanMessageCurrentAddress.Text;
            string actualPermanentAddress = spanMessagePermanentAddress.Text;

            Assert.IsTrue(actualName.Contains(expectedFullName), $"actual: {actualName}, expected: {expectedFullName}");
            Assert.AreEqual(expectedEmail, actualEmail);
            Assert.AreEqual(expectedCurrentAddress, actualCurrentAddress);
            Assert.AreEqual(expectedPermanentAddress, actualPermanentAddress);

            driver.Quit();
        }


        [Test]
        public void InvalidEmailTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Position = new System.Drawing.Point(2000, 1);
            driver.Manage().Window.Maximize();

            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputInvalidEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            string beforeValue = inputInvalidEmail.GetAttribute("class");

            inputInvalidEmail.SendKeys("montrimaite.ievagmail.com");
            buttonSubmit.Click();

            string afterValue = inputInvalidEmail.GetAttribute("class");

            Assert.AreEqual(beforeValue, afterValue);

            driver.Quit();
        }      
    }
 }
