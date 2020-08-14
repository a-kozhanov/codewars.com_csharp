using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsthisTriangleTests
    {
        [Test]
        public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
        {
            Assert.IsTrue(IsthisTriangle.IsTriangle(5, 7, 10));
        }

        [TestCase(1, 2, 3)]
        [TestCase(1, 3, 2)]
        [TestCase(3, 1, 2)]
        public void IsTriangle_SumOfSidesEqualOtherSide_ReturnsFalse(int a, int b, int c)
        {
            Assert.IsFalse(IsthisTriangle.IsTriangle(a, b, c));
        }

        [TestCase(-1, 2, 3)]
        [TestCase(1, -2, 3)]
        [TestCase(1, 2, -3)]
        public void IsTriangle_NegativeSides_ReturnsFalse(int a, int b, int c)
        {
            Assert.IsFalse(IsthisTriangle.IsTriangle(a, b, c));
        }

        [TestCase(1, 2, 4)]
        [TestCase(4, 1, 2)]
        [TestCase(1, 4, 2)]
        public void IsTriangle_PositiveSides_ReturnsFalse(int a, int b, int c)
        {
            Assert.IsFalse(IsthisTriangle.IsTriangle(a, b, c));
        }
    }
}