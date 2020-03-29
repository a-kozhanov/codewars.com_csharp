using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MaximumProductTests
    {
        [TestCase(40, 5, 8)]
        [TestCase(06, 1, 2, 3)]
        [TestCase(90, 1, 5, 10, 9)]
        [TestCase(06, 5, 1, 2, 3, 1, 4)]
        [TestCase(48, 4, 12, 3, 1, 5)]
        public void PositiveNumbers(int expexted, params int[] a)
        {
            Assert.That(MaximumProduct.AdjacentElementsProduct(a), Is.EqualTo(expexted));
        }

        [TestCase(21, 3, 6, -2, -5, 7, 3)]
        [TestCase(50, 9, 5, 10, 2, 24, -1, -48)]
        [TestCase(30, 5, 6, -4, 2, 3, 2, -23)]
        [TestCase(-14, -23, 4, -5, 99, -27, 329, -2, 7, -921)]
        public void MixedValues(int expexted, params int[] a)
        {
            Assert.That(MaximumProduct.AdjacentElementsProduct(a), Is.EqualTo(expexted));
        }

        [TestCase(0, 1, 0, 1, 0, 1000)]
        [TestCase(6, 1, 2, 3, 0)]
        public void ContainingZeroes(int expexted, params int[] a)
        {
            Assert.That(MaximumProduct.AdjacentElementsProduct(a), Is.EqualTo(expexted));
        }
    }
}