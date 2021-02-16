using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CalculateHarmonicTests
    {
        [Test]
        public static void test1()
        {
            Assert.AreEqual(9.3333, CalculateHarmonic.HarmPoints(6, 10, 11));
            Assert.AreEqual(7.1429, CalculateHarmonic.HarmPoints(2, 10, 20));
        }
    }
}