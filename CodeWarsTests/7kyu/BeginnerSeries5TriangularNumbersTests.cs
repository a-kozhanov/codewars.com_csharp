using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BeginnerSeries5TriangularNumbersTests
    {
        BeginnerSeries5TriangularNumbers triangular = new BeginnerSeries5TriangularNumbers();

        [Test]
        public void TriangularTests()
        {
            Assert.AreEqual(true, triangular.isTriangular(6));
        }
    }
}