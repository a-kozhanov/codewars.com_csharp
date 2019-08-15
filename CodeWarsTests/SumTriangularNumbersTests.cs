using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumTriangularNumbersTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(56, SumTriangularNumbers.sumTriangularNumbers(6));
            Assert.AreEqual(7140, SumTriangularNumbers.sumTriangularNumbers(34));
            Assert.AreEqual(0, SumTriangularNumbers.sumTriangularNumbers(-291));
            Assert.AreEqual(140205240, SumTriangularNumbers.sumTriangularNumbers(943));
            Assert.AreEqual(0, SumTriangularNumbers.sumTriangularNumbers(-971));
        }
    }
}