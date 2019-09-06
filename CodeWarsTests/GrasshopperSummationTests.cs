using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperSummationTests
    {
        [Test]
        public static void BasicTests()
        {
            Assert.AreEqual(1, GrasshopperSummation.summation(1));
            Assert.AreEqual(36, GrasshopperSummation.summation(8));
            Assert.AreEqual(253, GrasshopperSummation.summation(22));
            Assert.AreEqual(5050, GrasshopperSummation.summation(100));
            Assert.AreEqual(22791, GrasshopperSummation.summation(213));
        }
    }
}