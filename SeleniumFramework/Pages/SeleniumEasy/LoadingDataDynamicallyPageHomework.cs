

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

        public static void WaitForImageToAppear()
        {
            string locator = "//*[@id='loading']/img";
            Common.WaitForImageToAppear(locator);
        }

        public static string GetPersonalInformation()
        {
            string locator = "//*[@id='loading']";
            return Common.GetElementText(locator);
        }
    }
}
