
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver;
        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }
        public static IWebDriver GetDriver()
        {
            return driver;
        }
        public static void OpenURL(string url)
        {
            driver.Url = url;// atidaro kaip su refresh

            // driver.Navigate().GoToUrl(url); // islaikomas kontekstas, veiksmai, kurie galejo buti atlikti
        }
        public static void QuitDriver()
        {
            driver.Quit();
        }

        //paklaust
        public static void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }
        public static void WindowPosition()
        {
            driver.Manage().Window.Position = new System.Drawing.Point(2000, 1);
        }
        public static void ScrollWindow(string jsCommand)
        {
            driver.ExecuteJavaScript(jsCommand);
        }
    }
}
