using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExpressionsMatterTests
    {
        [TestCase(6, 2, 1, 2)]
        [TestCase(3, 1, 1, 1)]
        [TestCase(4, 2, 1, 1)]
        [TestCase(9, 1, 2, 3)]
        [TestCase(5, 1, 3, 1)]
        [TestCase(8, 2, 2, 2)]
        public void CheckSmallValues(int expected, params int[] a)
        {
            Assert.That(ExpMatter.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
        }
        [TestCase(020, 5, 1, 3)]
        [TestCase(105, 3, 5, 7)]
        [TestCase(035, 5, 6, 1)]
        [TestCase(008, 1, 6, 1)]
        [TestCase(014, 2, 6, 1)]
        [TestCase(048, 6, 7, 1)]
        public void CheckIntermediateValues(int expected, params int[] a)
        {
            Assert.That(ExpMatter.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
        }
        [TestCase(060, 02, 10, 03)]
        [TestCase(027, 01, 08, 03)]
        [TestCase(126, 09, 07, 02)]
        [TestCase(020, 01, 01, 10)]
        [TestCase(018, 09, 01, 01)]
        [TestCase(300, 10, 05, 06)]
        [TestCase(012, 01, 10, 01)]
        public void CheckMixedValues(int expected, params int[] a)
        {
            Assert.That(ExpMatter.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
        }
    }
}