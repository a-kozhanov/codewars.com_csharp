using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NextBiggerNumberWithSameDigitsTests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Small Number");
            Assert.AreEqual(21, NextBiggerNumberWithSameDigits.NextBiggerNumber(12));
            Assert.AreEqual(531, NextBiggerNumberWithSameDigits.NextBiggerNumber(513));
            Assert.AreEqual(2071, NextBiggerNumberWithSameDigits.NextBiggerNumber(2017));
            Assert.AreEqual(441, NextBiggerNumberWithSameDigits.NextBiggerNumber(414));
            Assert.AreEqual(414, NextBiggerNumberWithSameDigits.NextBiggerNumber(144));
        }
    }
}