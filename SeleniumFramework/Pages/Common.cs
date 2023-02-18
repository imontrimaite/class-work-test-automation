using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;

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
        private static void ExecuteJavaScript(string script)
        {
            Driver.GetDriver().ExecuteJavaScript(script);
        }
        internal static void ScrollBy(int pixelsRight, int pixelsDown)
        {
            ExecuteJavaScript($"window.scrollBy({pixelsRight}, {pixelsDown})");
        }

        internal static void WaitMilliSeconds(int milliseconds)
        {
            System.Threading.Thread.Sleep(milliseconds);
        }

        internal static string GetCssAttributeValue(string locator, string propertyName)
        {
            return GetElement(locator).GetCssValue(propertyName);
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }
    }
}
