using Calculator;
using NUnit.Framework;

namespace UnitTests
{
    // nera Main'o, tai tik biblioteka
    public class CalculatorUnitTests
    {
        [Test]
        public void Sum1and1()
        {
            int expectedResult = 2;

            int actualResult = Calculator.CalculatorClass.SumInt(1, 1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        // glaustesnis variantas
        [Test]
        public void Sum2And2()
        { 
            Assert.AreEqual(4, Calculator.CalculatorClass.SumInt(2, 2));
        }

        [Test]// netikslus duomenys
        public void SumDouble01And01And01()
        {
            double expectedResult = 0.3; 

            double actualResult = Calculator.CalculatorClass.SumDouble3(0.1, 0.1, 0.1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test] // tiksliau su decimal
        public void SumDecimal01And01And01()
        {
            decimal expectedResult = 0.3m;

            decimal actualResult = Calculator.CalculatorClass.SumDecimal3(0.1m, 0.1m, 0.1m);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Sum3And3()
        {
            Assert.AreEqual(6, Calculator.CalculatorClass.SumInt(3, 3));
        }
    }
}
