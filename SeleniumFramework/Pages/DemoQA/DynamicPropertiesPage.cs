
using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class DynamicPropertiesPage
    {
        public static void Open()
        {
            Common.WindowPosition();
            Common.MaximizeWindow();
            Driver.OpenURL("https://demoqa.com/dynamic-properties");
        }

        public static bool WaitForButtonToBeClickable()
        {
            string locator = "//*[@id='enableAfter']";
            Common.WaitForElementToBeClickable(locator);
            return Common.CheckIfElementIsEnabled(locator);
        }

        public static void WaitForButtonClassToChange()
        {
            string locator = "//*[@id='colorChange']";
            Common.WaitForElementAttributeToContainValue(locator, "class", "text-danger");
        }

        public static void WaitForButtonTextToBeRed()
        {
            string locator = "//*[@id='colorChange']";
            Common.WaitForElementCssPropertyToBe(locator, "text-color", "rgb(255, 0, 0)");
        }

        public static void WaitForButtonTextToBeVisible()
        {
            string locator = "//*[@id='visibleAfter']";
            Common.WaitForElementToBeVisible(locator);
        }
    }
}
