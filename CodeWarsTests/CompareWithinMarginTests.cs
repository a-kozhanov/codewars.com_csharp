using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CompareWithinMarginTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(-1, CompareWithinMargin.CloseCompare(4, 5));
            Assert.AreEqual(0, CompareWithinMargin.CloseCompare(5, 5));
            Assert.AreEqual(1, CompareWithinMargin.CloseCompare(6, 5));
            Assert.AreEqual(-1, CompareWithinMargin.CloseCompare(-6, -5));

            Assert.AreEqual(0, CompareWithinMargin.CloseCompare(2, 5, 3));
            Assert.AreEqual(1, CompareWithinMargin.CloseCompare(8.1, 5, 3));
            Assert.AreEqual(-1, CompareWithinMargin.CloseCompare(1.99, 5, 3));
        }
    }
}