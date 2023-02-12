using System;
using NUnit.Framework;

namespace UnitTests
{
    public class EvenNumbersTest
    {
         [Test]
         public void FourEvenNumbersBetween1And10Test()
         {
              int count = 0;

              for (int i = 1; i <= 10; i++)
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
