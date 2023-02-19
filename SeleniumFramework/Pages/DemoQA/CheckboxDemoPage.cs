
using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class CheckboxDemoPage
    {
        private static string inputSingleCheckbox = "//*[@id='isAgeSelected']";
        private static string fieldSingleCheckboxSuccessMessage = "//*[@id='txtAge']";

        public static void Open()
        {
            Common.WindowPosition();
            Common.MaximizeWindow();
            Driver.OpenURL("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        public static void ClickSingleCheckbox()
        {
            Common.ClickElement(inputSingleCheckbox);
        }

        public static string GetSingleCheckboxSuccessMessage()
        {
            return Common.GetElementText(fieldSingleCheckboxSuccessMessage);
        }
    }
}
