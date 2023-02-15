
using System;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    // cia yra Page Object Model, jis neturi buti priklausomas nuo seleniumas
    public class SimpleFormDemo
    {
        public static void EnterMessage(string message)
        {
            string locator = "//*[@id='user-message']";
            Common.SendKeys(locator, message);

            // IWebElement inputEnterMessage = driver.FindElement(By.XPath("//*[@id='user-message']"));

        }
        public static void ClickShowMessageButton()
        {
            string locator = "//*[@id='get-input']/button";
            Common.ClickElement(locator);

            // IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
        }
        public static string GetSingleInputFieldMessage()
        {
            string locator = "//*[@id='display']";
            return Common.GetElementText(locator);

            // IWebElement spanMessageText = driver.FindElement(By.XPath("//*[@id='display']"));
        }

        public static void EnterInputA(string value)
        {
            string locator = "//*[@id='sum1']";
            Common.SendKeys(locator, value);
        }

        public static void EnterInputB(string value)
        {
            string locator = "//*[@id='sum1']";
            Common.SendKeys(locator, value);
        }

        public static void ClickGetTotalButton()
        {
            string locator = "//*[@id='gettotal']/button";
            Common.ClickElement(locator);
        }

        public static string GetTwoInputFieldMessage()
        {
            string locator = "//*[@id='displayvalue']";
            return Common.GetElementText(locator);
        }
    }
}
