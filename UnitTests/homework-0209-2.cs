using System;
using NUnit.Framework;

namespace UnitTests
{    
    public class TodayIsWednesdayTest
    {
        [Test]
        public void TodayIsWednesdayMethod()
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            Assert.AreEqual(today, DayOfWeek.Wednesday); 
        }
    }

}