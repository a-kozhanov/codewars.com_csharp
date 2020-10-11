using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NumbersWithThisDigitInsideTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new long[] {0, 0, 0}, NumbersWithThisDigitInside.NumbersWithDigitInside(5, 6));
            Assert.AreEqual(new long[] {1, 6, 6}, NumbersWithThisDigitInside.NumbersWithDigitInside(7, 6));
            Assert.AreEqual(new long[] {3, 22, 110}, NumbersWithThisDigitInside.NumbersWithDigitInside(11, 1));
            Assert.AreEqual(new long[] {2, 30, 200}, NumbersWithThisDigitInside.NumbersWithDigitInside(20, 0));
            Assert.AreEqual(new long[] {9, 286, 5955146588160},
                NumbersWithThisDigitInside.NumbersWithDigitInside(44, 4));
        }
    }
}