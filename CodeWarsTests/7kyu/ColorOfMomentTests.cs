using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ColorOfMomentTests
    {
        [Test]
        public void _0_BasicTests()
        {
            var kata = new ColorOfMoment();
            Assert.AreEqual("13:55:55", kata.HexToTime("#0d3737"));
            Assert.Throws<Exception>(() => kata.HexToTime("#2c3721"), "Thats not a valid time!");
        }
    }
}