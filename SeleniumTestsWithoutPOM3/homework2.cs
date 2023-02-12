using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsWithoutPOM3
{
    internal class homework2
    {
        [Test]
        public void TextBoxTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demoqa.com/text-box";
            driver.Manage().Window.Maximize();


            string expectedFullName = "Ieva Montrimaite";
            string expectedEmail = "montrimaite.ieva@gmail.com";
            string expectedCurrentAddress = "2436 N 48th St #101, Lincoln, New Hampshire";
            string expectedPermanentAddress = "8602 SW State Road 200, Ocala, Florida";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            IWebElement spanMessageName = driver.FindElement(By.XPath("//*[@id='name']"));
            IWebElement spanMessageEmail = driver.FindElement(By.XPath("//*[@id='email']"));
            IWebElement spanMessageCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement spanMessagePermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            
            inputFullName.SendKeys(expectedFullName);
            inputEmail.SendKeys(expectedEmail);
            inputCurrentAddress.SendKeys(expectedCurrentAddress);
            inputPermanentAddress.SendKeys(expectedPermanentAddress);
            buttonSubmit.Click(); //neveikia      

            string actualName = spanMessageName.Text;
            string actualEmail = spanMessageEmail.Text;
            string actualCurrentAddress = spanMessageCurrentAddress.Text;
            string actualPermanentAddress = spanMessagePermanentAddress.Text;

            Assert.AreEqual(expectedFullName, actualName);
            Assert.AreEqual(expectedEmail, actualEmail);
            Assert.AreEqual(expectedCurrentAddress, actualCurrentAddress);
            Assert.AreEqual(expectedPermanentAddress, actualPermanentAddress);

            driver.Quit();
        }

        [Test]
        public void FaultyEmailTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demoqa.com/text-box";

            string expectedFullName = "Ieva Montrimaite";
            string expectedEmail = "montrimaite.ievagmail.com";
            string expectedCurrentAddress = "2436 N 48th St #101, Lincoln, New Hampshire";
            string expectedPermanentAddress = "8602 SW State Road 200, Ocala, Florida";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            IWebElement faultyEmail = driver.FindElement(By.XPath("//input[@class='mr-sm-2 field-error form-control']"));

            inputFullName.SendKeys(expectedFullName);
            inputEmail.SendKeys(expectedEmail);
            inputCurrentAddress.SendKeys(expectedCurrentAddress);
            inputPermanentAddress.SendKeys(expectedPermanentAddress);
            buttonSubmit.Click(); //neveikia

            Assert.AreEqual(expectedEmail, faultyEmail);

            driver.Quit();
        }
    }
}
