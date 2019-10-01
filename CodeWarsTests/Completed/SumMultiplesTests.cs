using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumMultiplesTests
    {
        [Test, Description("Should produce expected results for valid inputs")]
        public void SampleTest()
        {
            Assert.AreEqual(20, SumMultiples.SumMul(2, 9));
            Assert.AreEqual(1860, SumMultiples.SumMul(4, 123));
            Assert.AreEqual(86469, SumMultiples.SumMul(123, 4567));
        }

        [Test, Description("Should throw for invalid inputs")]
        public void ErrorTest()
        {
            Assert.Throws<ArgumentException>(() => SumMultiples.SumMul(4, 1));
            Assert.Throws<ArgumentException>(() => SumMultiples.SumMul(0, 20));
        }
    }
}