using CalcLibrary;
using NUnit.Framework;

namespace CalcLibrary.Tests1
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator = null;
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 15, 20)]
        [TestCase(100, 200, 300)]
        public void Add_Test(int a, int b, int expected)
        {
            int actual = calculator.Add(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}