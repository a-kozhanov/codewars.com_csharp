using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class UniqueSumTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(6, KataUniqueSum.UniqueSum(new List<int>() {1, 2, 3}));
            Assert.AreEqual(12, KataUniqueSum.UniqueSum(new List<int>() {1, 3, 8, 1, 8}));
            Assert.AreEqual(-1, KataUniqueSum.UniqueSum(new List<int>() {-1, -1, 5, 2, -7}));
        }
    }
}