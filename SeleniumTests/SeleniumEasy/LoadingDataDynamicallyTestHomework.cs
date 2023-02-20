using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class LoadingDataDynamicallyTestHomework
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            LoadingDataDynamicallyPageHomework.Open();
        }

        [Test]
        public void LoadingDataDynamicallyTest()
        {
            LoadingDataDynamicallyPageHomework.ClickGetNewUserButton();
            LoadingDataDynamicallyPageHomework.WaitForImageToAppear();
            System.Threading.Thread.Sleep(3000);

            string personalInformation = LoadingDataDynamicallyPageHomework.GetPersonalInformation();

            Assert.IsTrue(personalInformation.Contains("First Name"));
            Assert.IsTrue(personalInformation.Contains("Last Name"));
        }
        

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
