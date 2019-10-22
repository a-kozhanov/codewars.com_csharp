using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test, Description("should calculate the result of valid inputs")]
        public void Test()
        {
            Assert.AreEqual(8, SimpleCalculator.Calculator(6, 2, '+'));
            Assert.AreEqual(1, SimpleCalculator.Calculator(4, 3, '-'));
            Assert.AreEqual(25, SimpleCalculator.Calculator(5, 5, '*'));
            Assert.AreEqual(1.25, SimpleCalculator.Calculator(5, 4, '/'));
        }

        [Test, Description("should throw ArgumentException with invalid inputs")]
        public void ErrorTest()
        {
            Assert.Throws<ArgumentException>(() => SimpleCalculator.Calculator(6, 2, '&'));
        }
    }
}