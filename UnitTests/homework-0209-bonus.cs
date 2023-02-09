using System;
using NUnit.Framework;

namespace UnitTests
{
    public class EvenNumbersTest
    {
         [Test]
         public void Test_That_There_Are_Four_Even_Numbers_Between_1_And_10()
         {
              int count = 0;

              for (int i = 1; i <= 10; i++) // fails if we include 10, passes if i < 10
              {
                  if (i % 2 == 0)
                  {
                      count++;
                  }
              }
              Assert.AreEqual(4, count);
         }
    }
}
