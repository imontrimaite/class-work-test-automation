using NUnit.Framework;

namespace UnitTests
{
    internal class Remainder995DividedBy3Test
    {
        [Test]
        public void Remainder995DividedBy3Method()
        { 
            int expectedResult = 0;

            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }       
    }
}
