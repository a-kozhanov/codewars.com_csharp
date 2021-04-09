using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SuitcasePackingTests
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual(true, SuitcasePacking.FitSquares(1, 2, 3, 2));
            Assert.AreEqual(false, SuitcasePacking.FitSquares(1, 2, 2, 1));
            Assert.AreEqual(false, SuitcasePacking.FitSquares(3, 2, 3, 2));
            Assert.AreEqual(false, SuitcasePacking.FitSquares(1, 2, 1, 2));
            Assert.AreEqual(false, SuitcasePacking.FitSquares(6, 5, 8, 7));
        }
    }
}