
using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class TextBoxPage
    {
        public static void Open()
        {
            Driver.OpenURL("https://demoqa.com/text-box");
        }
        public static void MaximizeWindow()
        {
            Common.MaximizeWindow();
        }
        public static void WindowPosition()
        {
            Common.WindowPosition();
        }
        public static void ScrollWindow(string jsCommand)
        {
            Common.ScrollWindow(jsCommand);
        }

        public static void InputFullName(string fullName)
        {
            string locator = "//*[@id='userName']";
            Common.SendKeys(locator, fullName);
        }
        public static void InputEmail(string email)
        {
            string locator = "//*[@id='userEmail']";
            Common.SendKeys(locator, email);
        }

        public static void InputCurrentAddress(string currentAddress)
        {
            string locator = "//*[@id='currentAddress']";
            Common.SendKeys(locator, currentAddress);
        }

        public static void InputPermanentAddress(string permanentAddress)
        {
            string locator = "//*[@id='permanentAddress']";
            Common.SendKeys(locator, permanentAddress);
        }

        public static void ClickSubmitButton()
        {
            string locator = "//*[@id='submit']";
            Common.ClickElement(locator);
        }

        public static string GetNameMessage()
        {
            string locator = "//*[@id='output']//*[@id='name']";
            return Common.GetElementText(locator);
        }

        public static string GetEmailMessage()
        {
            string locator = "//*[@id='output']//*[@id='email']";
            return Common.GetElementText(locator);
        }

        public static string GetCurrentAddressMessage()
        {
            string locator = "//*[@id='output']//*[@id='currentAddress']";
            return Common.GetElementText(locator);
        }

        public static string GetPermanentAddressMessage()
        {
            string locator = "//*[@id='output']//*[@id='permanentAddress']";
            return Common.GetElementText(locator);
        }

        public static string GetAttribute(string className)
        {
            string locator = "//*[@id='userEmail']";
            return Common.GetAttribute(locator, className);
        }
        public static string GetCssValue(string cssValue)
        {
            string locator = "//*[@id='userEmail']";
            return Common.GetCssValue(locator, cssValue);
        }
    }
}
