using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ProductOfArrayItemsTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(540, ProductOfArrayItems.Product(new int[] {5, 4, 1, 3, 9}));
            Assert.AreEqual(-672, ProductOfArrayItems.Product(new int[] {-2, 6, 7, 8}));
            Assert.AreEqual(10, ProductOfArrayItems.Product(new int[] {10}));
            Assert.AreEqual(0, ProductOfArrayItems.Product(new int[] {0, 2, 9, 7}));
        }

        [Test]
        public void ArgumentNullTest()
        {
            Assert.Throws<ArgumentNullException>(() => { ProductOfArrayItems.Product(null); });
        }

        [Test]
        public void InvalidOperationTest()
        {
            Assert.Throws<InvalidOperationException>(() => { ProductOfArrayItems.Product(new int[] { }); });
        }
    }
}