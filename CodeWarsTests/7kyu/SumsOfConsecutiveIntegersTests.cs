using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumsOfConsecutiveIntegersTests
    {
        [Test]
        public void Position1Sanity()
        {
            Assert.AreEqual(5, SumsOfConsecutiveIntegers.Position(4, 14, 3));
        }

        [Test]
        public void Position2Sanity()
        {
            Assert.AreEqual(12, SumsOfConsecutiveIntegers.Position(2, 25, 0));
        }

        [Test]
        public void Position3Sanity()
        {
            Assert.AreEqual(109, SumsOfConsecutiveIntegers.Position(7, 749, 5));
        }

        [Test]
        public void Position4Sanity()
        {
            Assert.AreEqual(-3, SumsOfConsecutiveIntegers.Position(3, -9, 1));
        }

        [Test]
        public void Position5Sanity()
        {
            Assert.AreEqual(-2, SumsOfConsecutiveIntegers.Position(5, 0, 0));
        }

        [Test]
        public void PositionIntRounding()
        {
            Assert.AreEqual(-110, SumsOfConsecutiveIntegers.Position(4, -446, 3));
        }
    }
}