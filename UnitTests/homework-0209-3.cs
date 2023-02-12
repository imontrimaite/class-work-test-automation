using System;
using NUnit.Framework;

namespace UnitTests
{
    public class NowIs13HTest
    {
        [Test]
        public void NowIs13HMethod()
        {
            var now = DateTime.Now;
            var expectedTime = new DateTime(now.Year, now.Month, now.Day, 13, 00, 0);

            Assert.IsTrue(now >= expectedTime && now < expectedTime.AddMinutes(1));
        }

        //arba
        [Test]
        public void CheckIfTimeNowIs300()
        {
            string expectedResult = "13:00";

            string actualResult = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
            // arba optimaliau
            // string actualResultFormatted = DateTime.Now.ToString("HH:mm");

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}