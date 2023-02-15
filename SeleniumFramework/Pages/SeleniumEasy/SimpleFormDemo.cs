using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class SimpleFormDemo
    {
        public static void ClickShowMessageButton()
        {
            throw new NotImplementedException();
        }

        public static string GetSingleInputFieldMessage()
        {
            throw new NotImplementedException();
        }

        // IWebElement inputEnterMessage = driver.FindElement(By.XPath("//*[@id='user-message']"));
        // IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
        //  IWebElement spanMessageText = driver.FindElement(By.XPath("//*[@id='display']"));
        public static void EnterMessage(string message)
        {
            string locator = "//*[@id='user-message']";
            Common.SendKeys(locator, message);
            
        }

    }
}
