

using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class SelectMenuPage
    {
        public static void Open()
        {
            Driver.OpenURL("https://demoqa.com/select-menu");
        }

        public static void SelectTitle(string expectedValue)
        {
            Common.ClickElement(Locators.SelectMenu.dropdownTitle);
            Common.ClickElement(Locators.SelectMenu.dropdownTitleOptionMr);
        }

        public static string GetSelectedTitle()
        {
            return Common.GetElementText(Locators.SelectMenu.dropdownTitle);
        }
    }
}
