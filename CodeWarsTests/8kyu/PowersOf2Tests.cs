using System.Numerics;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PowersOf2Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new BigInteger[] { 1 }, PowersOf2.PowersOfTwo(0));
            Assert.AreEqual(new BigInteger[] { 1, 2 }, PowersOf2.PowersOfTwo(1));
            Assert.AreEqual(new BigInteger[] { 1, 2, 4, 8, 16 }, PowersOf2.PowersOfTwo(4));
        }
    }
}