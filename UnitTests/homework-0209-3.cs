using System;
using NUnit.Framework;

namespace NowIs13H
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
    }
}