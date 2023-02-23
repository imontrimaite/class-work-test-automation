
using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class TooltipsPage
    {
        public static void Open()
        {
            Driver.OpenURL("https://demoqa.com/tool-tips");
        }

        public static string GetTooltipMessage()
        {
            Common.MouveMouseToElement(Locators.Tooltips.buttonHoverMeToSee);
            Common.WaitForElementToBeVisible(Locators.Tooltips.elementTooltip);
            return Common.GetElementText(Locators.Tooltips.elementTooltip);
        }
    }
}
