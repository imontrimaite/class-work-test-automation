using System;
using NUnit.Framework;

namespace TodayIsWednesdayTest
{
    
    public class TodayIsWednesdayUnitTest
    {
        [Test]
        public void TodayIsWednesdayMethod()
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;

            Assert.AreEqual(today, DayOfWeek.Wednesday); 
        }
    }

}