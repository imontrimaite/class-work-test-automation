
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
    }
}
