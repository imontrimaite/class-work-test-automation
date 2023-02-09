
using NUnit.Framework;

namespace UnitTests
{
    internal class homework_0209
    {
        [Test]
        public void CheckRemainder995DividedBy3()
        { 
            int expectedResult = 0;

            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
