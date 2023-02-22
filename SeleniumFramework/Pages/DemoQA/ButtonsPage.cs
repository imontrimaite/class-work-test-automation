
using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class ButtonsPage
    {
        public static void Open()
        {
            Common.WindowPosition();
            Common.MaximizeWindow();
            Driver.OpenURL("https://demoqa.com/buttons");
        }

        public static void DoubleClickButton()
        {
            Common.DoubleClickElement(Locators.Buttons.buttonDoubleClick);
        }

        public static string GetDoubleClickMessage()
        {
            return Common.GetElementText(Locators.Buttons.messageDoubleClick);
        }

        public static void RightClickButton()
        {
            Common.RightClickElement(Locators.Buttons.buttonRightClick);
        }

        public static void LeftClickButton()
        {
            Common.LeftClickElement(Locators.Buttons.buttonLeftClick);
        }

        public static string GetRightClickMessage()
        {
            return Common.GetElementText(Locators.Buttons.messageRightClick);
        }

        public static string GetLeftClickMessage()
        {
            return Common.GetElementText(Locators.Buttons.messageLeftClick);
        }
    }
}
