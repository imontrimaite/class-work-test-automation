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

        //arba
        [Test]

        public void CheckIfTodayIsWednesday()
        { 
            DayOfWeek expectedResult = DayOfWeek.Wednesday;

            DateTime now = DateTime.Now;
            DayOfWeek actualResult = DateTime.Now.DayOfWeek;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }

}