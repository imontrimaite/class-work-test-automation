using NUnit.Framework;

namespace UnitTests
{
    internal class CheckRemainder995DividedBy3
    {
        [Test]
        public void CheckRemainder995DividedBy3Method()
        { 
            int expectedResult = 0;

            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }       
    }
}
