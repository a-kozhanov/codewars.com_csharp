using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BitCountingTests
    {
        [Test]
        public void CountBits()
        {
            Assert.AreEqual(0, BitCounting.CountBits(0));
            Assert.AreEqual(1, BitCounting.CountBits(4));
            Assert.AreEqual(3, BitCounting.CountBits(7));
            Assert.AreEqual(2, BitCounting.CountBits(9));
            Assert.AreEqual(2, BitCounting.CountBits(10));
        }
    }
}