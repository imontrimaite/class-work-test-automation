

using System;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class LoadingDataDynamicallyPageHomework
    {
        public static void Open()
        {
            Common.WindowPosition();
            Common.MaximizeWindow();
            Driver.OpenURL("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");
        }

        public static void ClickGetNewUserButton()
        {
            string locator = "//*[@id='save']";
            Common.ClickElement(locator);
        }

        public static string GetPersonalInformation()
        {
            string locator = "//*[@id='loading']";
            Common.WaitForElementToNotContainText(locator, "loading...");
            return Common.GetElementText(locator);
        }
    }
}
