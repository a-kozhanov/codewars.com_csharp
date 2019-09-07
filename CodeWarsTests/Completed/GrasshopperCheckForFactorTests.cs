using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperCheckForFactorTests
    {
        [Test]
        [TestCase(10, 2, true)]
        [TestCase(63, 7, true)]
        [TestCase(2450, 5, true)]
        [TestCase(24612, 3, true)]
        [TestCase(9, 2, false)]
        [TestCase(653, 7, false)]
        [TestCase(2453, 5, false)]
        [TestCase(24617, 3, false)]
        public static void FixedTest(int num, int factor, bool isFactor)
        {
            Assert.AreEqual(isFactor, GrasshopperCheckForFactor.CheckForFactor(num, factor));
        }
    }
}