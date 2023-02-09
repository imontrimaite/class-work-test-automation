using System;
using NUnit.Framework;

namespace TodayIsWednesdayTest
{
    
    public class TodayIsWednesdayUnitTest
    {
        [Test]
        public void TestMethod1()
        {
            // Get today's day of the week
            DayOfWeek today = DateTime.Today.DayOfWeek;

            // Verify that today's day of the week is equal to Wednesday
            Assert.AreEqual(today, DayOfWeek.Wednesday);
        }
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}