using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace SeleniumTestsWithoutPOM3
{
    internal class homework2
    {
        [Test]
        public void TextBoxTest()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Position = new System.Drawing.Point(2000, 1);
            driver.Manage().Window.Maximize();

            driver.Url = "https://demoqa.com/text-box";

            string expectedFullName = "Ieva Montrimaite";
            string expectedEmail = "montrimaite.ieva@gmail.com";
            string expectedCurrentAddress = "test current address";
            string expectedPermanentAddress = "test permanent address";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            inputFullName.SendKeys(expectedFullName);
            inputEmail.SendKeys(expectedEmail);
            inputCurrentAddress.SendKeys(expectedCurrentAddress);
            inputPermanentAddress.SendKeys(expectedPermanentAddress);

            // Senas budas 
            // IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            // jse.ExecuteScript("window.scrollBy(0, 200)");

            // naujas budas pascrollint
            driver.ExecuteJavaScript("window.scrollBy(0, 200)");
            buttonSubmit.Click();

            IWebElement spanMessageName = driver.FindElement(By.XPath("//*[@id='output']//*[@id='name']"));
            IWebElement spanMessageEmail = driver.FindElement(By.XPath("//*[@id='output']//*[@id='email']"));
            IWebElement spanMessageCurrentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='currentAddress']"));
            IWebElement spanMessagePermanentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='permanentAddress']"));

            string actualName = spanMessageName.Text;
            string actualEmail = spanMessageEmail.Text;
            string actualCurrentAddress = spanMessageCurrentAddress.Text;
            string actualPermanentAddress = spanMessagePermanentAddress.Text;

            Assert.IsTrue(actualName.Contains(expectedFullName), $"actual: {actualName}, expected: {expectedFullName}");
            Assert.IsTrue(actualEmail.Contains(expectedEmail), $"actual: {actualEmail}, expected: {expectedEmail}");
            Assert.IsTrue(actualCurrentAddress.Contains(expectedCurrentAddress), $"actual: {actualCurrentAddress}, expected: {expectedCurrentAddress}");
            Assert.IsTrue(actualPermanentAddress.Contains(expectedPermanentAddress), $"actual: {actualPermanentAddress}, expected: {expectedPermanentAddress}");

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

            // Console.WriteLine(inputInvalidEmail.GetCssValue("border-color"));tik paziuret, kokia spalva

            inputInvalidEmail.SendKeys("montrimaite.ievagmail.com");
            buttonSubmit.Click();

            System.Threading.Thread.Sleep(1000); //kreipiasi i sistema ir uzmigdo

            // Console.WriteLine(inputInvalidEmail.GetCssValue("border-color")); tik paziuret, kokia spalva

            string afterValue = inputInvalidEmail.GetAttribute("class");

            // patikriname realia border spalva
            Assert.AreEqual("rgb(255, 0, 0)", inputInvalidEmail.GetCssValue("border-color"));

            // patikriname, kad buvo uzdeta papildoma klase input elementui
            Assert.AreNotEqual(beforeValue, afterValue);

            driver.Quit();

            // $x() - galime ivesti xpath web consolej ir rasti elementa
        }      
    }
 }
