using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TriangularTreasureTests
    {
        [Test]
        public static void TriangularTwoShouldBeThree()
        {
            Assert.AreEqual(3, TriangularTreasure.Triangular(2));
        }

        [Test]
        public static void TriangularFourShouldBeTen()
        {
            Assert.AreEqual(10, TriangularTreasure.Triangular(4));
        }
    }
}