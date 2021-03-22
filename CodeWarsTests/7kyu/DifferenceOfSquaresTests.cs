using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DifferenceOfSquaresTests
    {
        [Test]
        [TestCase(5, ExpectedResult = 170)]
        [TestCase(10, ExpectedResult = 2640)]
        [TestCase(100, ExpectedResult = 25164150)]
        public static int FixedTest(int x)
        {
            return KataDifferenceOfSquares.DifferenceOfSquares(x);
        }
    }
}