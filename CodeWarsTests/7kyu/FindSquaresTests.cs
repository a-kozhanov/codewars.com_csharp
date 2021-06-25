using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindSquaresTests
    {
        [Test]
        public void testBasicNumbers()
        {
            Assert.AreEqual(FindSquares.findSquares(9), "25-16");
        }

        [Test]
        public void testSmallerNumbers()
        {
            Assert.AreEqual(FindSquares.findSquares(1), "1-0");
        }

        [Test]
        public void testBiggerNumbers()
        {
            Assert.AreEqual(FindSquares.findSquares(1887), "891136-889249");
            Assert.AreEqual(FindSquares.findSquares(99991), "2499600016-2499500025");
        }
    }
}