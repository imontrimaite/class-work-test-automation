
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

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

        public static string TakeScreenshot(string methodName)
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.png";
            string screenshotFilePath = $"{screenshotsDirectoryPath}\\{screenshotName}";

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            Directory.CreateDirectory(screenshotsDirectoryPath);
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
            return screenshotFilePath;
        }
    }
}
