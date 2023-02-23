using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IEnumerable<IWebElement> elements;

        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            { 
                element.Click();
            }
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

        internal static List<bool> GetMultipleElementSelectedStatus(string locator)
        {
            List<IWebElement> elements = GetElements(locator);
            List<bool> statuses = new List<bool>();

            foreach (IWebElement element in elements)
            {
                statuses.Add(element.Selected);
            }
            return statuses;
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

        internal static void WaitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }
        internal static void WaitForElementAttributeToContainValue(string locator, string attributeName, string attributePartialValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(attributePartialValue));
        }

        internal static void WaitForElementCssPropertyToBe(string locator, string cssPropertyName, string cssPropertyValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).GetCssValue(cssPropertyName).Equals(cssPropertyValue));
        }
        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            // wait.PollingInterval = TimeSpan.FromSeconds(4); // Fluent wait, tikrina intervalais kas 4 sekundes, kol elementas nepasidaro visible
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }
        internal static bool CheckIfElementIsEnabled(string locator)
        {
            return GetElement(locator).Enabled;
        }

        internal static bool CheckIfElementIsSelected(string locator)
        {
            return GetElement(locator).Selected;
        }

        internal static bool CheckIfAllOptionsAreSelected(string locator)
        {
            List<IWebElement> elements = GetElements(locator);
            bool anySelected = false;

            foreach (IWebElement element in elements)
            {
                if (element.Selected)
                {
                    anySelected = true;
                }
            }
            return anySelected;

            //arba: return GetElements(locator).Select(e => e.Selected).Any();
        }

        internal static void WaitForElementToNotContainText(string locator, string textToNotBePresent)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => !d.FindElement(By.XPath(locator)).Text.Contains(textToNotBePresent));
        }

        internal static void DoubleClickElement(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.DoubleClick(element);
            actions.Perform();
        }

        internal static void RightClickElement(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.ContextClick(element);
            actions.Perform();
        }

        internal static void LeftClickElement(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.Click(element);
            actions.Perform();
        }

        internal static void MouveMouseToElement(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.MoveToElement(element);
            actions.Perform();
        }

        private static SelectElement GetSelectElement(string locator) // papildomas metodas, jei yra daug metodu su select
        { 
            IWebElement element = GetElement(locator);
            return new SelectElement(element);
        }
        internal static void SelectOptionByValue(string locator, string value)
        {
            SelectElement selectElement = GetSelectElement(locator);
            selectElement.SelectByValue(value);
        }

        internal static void SelectOptionByText(string locator, string text)
        {
            SelectElement selectElement = GetSelectElement(locator);
            selectElement.SelectByText(text);
        }
    }
}
