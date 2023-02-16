using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }
        internal static void SendKeys(string locator, string message)
        {
            GetElement(locator).SendKeys(message);
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void MaximizeWindow()
        {
            Driver.GetDriver().Manage().Window.Maximize();
        }
        internal static void WindowPosition()
        {
            Driver.GetDriver().Manage().Window.Position = new System.Drawing.Point(2000, 1);
        }
        internal static void ScrollWindow(string jsCommand)
        {
            Driver.GetDriver().ExecuteJavaScript(jsCommand);
        }
        internal static string GetAttribute(string locator, string className)
        {
            return GetElement(locator).GetAttribute(className);
        }
        internal static string GetCssValue(string locator, string cssValue)
        {
            return GetElement(locator).GetCssValue(cssValue);
        }
    }
}
