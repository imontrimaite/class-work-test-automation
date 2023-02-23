

using System;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class SelectDropdownListPage
    {
        public static void Open()
        {
            Driver.OpenURL("https://demo.seleniumeasy.com/basic-select-dropdown-demo.html");
        }

        public static void SelectDay(string expectedDay)
        {
            string selectElementLocator = "//*[@id='select-demo']";
            Common.SelectOptionByValue(selectElementLocator, expectedDay);
        }

        public static string GetSelectedDay()
        {
            string locator = "//*[@class='selected-value']";
            return Common.GetElementText(locator);
        }
    }
}
