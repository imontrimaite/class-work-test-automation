
using System;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class CheckboxDemoPageHomework
    {
        public static void Open()
        {
            Common.WindowPosition();
            Common.MaximizeWindow();
            Driver.OpenURL("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        public static void clickCkeckAllButton()
        {
            string locator = "//*[@id='check1']";
            Common.ClickElement(locator);
        }

        public static bool GetCheckedOption1Status()
        {
            string locator = "//*[@class='cb1-element']";
            return Common.CheckIfOption1IsSelected(locator);
        }

        public static bool GetCheckedOption2Status()
        {
            string locator = "(//*[@class='cb1-element'])[2]";
            return Common.CheckIfOption2IsSelected(locator);
        }

        public static bool GetCheckedOption3Status()
        {
            string locator = "(//*[@class='cb1-element'])[3]";
            return Common.CheckIfOption3IsSelected(locator);
        }


        public static bool GetCheckedOption4Status()
        {
            string locator = "(//*[@class='cb1-element'])[4]";
            return Common.CheckIfOption4IsSelected(locator);
        }

        public static bool CheckIfAllCheckboxesAreSelected()
        {
            string locator = "//*[@class='cb1-element']";
            return Common.CheckIfAllOptionsAreSelected(locator);
        }
    }
}
