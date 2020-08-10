using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SortOddTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] {1, 3, 2, 8, 5, 4}, SortOdd.SortArray(new int[] {5, 3, 2, 8, 1, 4}));
            Assert.AreEqual(new int[] {1, 3, 5, 8, 0}, SortOdd.SortArray(new int[] {5, 3, 1, 8, 0}));
            Assert.AreEqual(new int[] { }, SortOdd.SortArray(new int[] { }));
        }
    }
}