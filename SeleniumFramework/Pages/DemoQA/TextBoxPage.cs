
using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class TextBoxPage
    {
        public static void Open()
        {
            Common.WindowPosition();
            Common.MaximizeWindow();
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
        public static void InputFullName(string fullNameValue)
        {
            Common.SendKeys(Locators.TextBoxPage.inputFullName, fullNameValue);
        }
        public static void InputEmail(string emailValue)
        {
            Common.SendKeys(Locators.TextBoxPage.inputEmail, emailValue);
        }

        public static void InputCurrentAddress(string currentAddressValue)
        {
            Common.SendKeys(Locators.TextBoxPage.inputCurrentAddress, currentAddressValue);
        }

        public static void InputPermanentAddress(string permanentAddressValue)
        {
            Common.SendKeys(Locators.TextBoxPage.inputPermanentAddress, permanentAddressValue);
        }

        public static void ClickSubmitButton()
        {
            Common.ScrollBy(0, 100); // kad nereiktu atsimint sitos sintakses: "window.scrollBy(0, 200)"
            Common.ClickElement(Locators.TextBoxPage.buttonSubmit);
        }

        public static string GetNameMessage()
        {
            return Common.GetElementText(Locators.TextBoxPage.outputFullName);
        }

        public static string GetEmailMessage()
        {
            return Common.GetElementText(Locators.TextBoxPage.outputEmail);
        }

        public static string GetCurrentAddressMessage()
        {
            return Common.GetElementText(Locators.TextBoxPage.outputCurrentAddress);
        }

        public static string GetPermanentAddressMessage()
        {
            return Common.GetElementText(Locators.TextBoxPage.outputPermanentAddress);
        }

        public static bool CheckIfemailBorderIsRed()
        {
            Common.WaitMilliSeconds(500);
            string cssBorderColor = Common.GetCssAttributeValue(Locators.TextBoxPage.inputEmail, "border-color");
            if (cssBorderColor == "rgb(255, 0, 0)")
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }
        public static bool CheckIfEmailErrorIsDisplayed()
        {
            string attributeClassValue = Common.GetAttributeValue(Locators.TextBoxPage.inputEmail, "class");
            if (attributeClassValue.Contains("field-error"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
