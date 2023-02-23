
using System;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class JavascriptAlertsPage
    {
        public static void Open()
        {
            Driver.OpenURL("https://demo.seleniumeasy.com/javascript-alert-box-demo.html");
        }

        public static void OpenSimpleAlert()
        {
            Common.ClickElement("(//*[contains(@class,'panel-primary')])[1]//button");
        }

        public static string GetAlertText()
        {
            return Common.GetAlertText();
        }
    }
}
