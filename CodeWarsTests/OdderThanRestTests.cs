using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OdderThanRestTests
    {
        [Test, Description("Your solution should pass basic tests")]
        public void FixedTest()
        {
            Assert.AreEqual(3, OdderThanRest.OddOne(new List<int> {2, 4, 6, 7, 10}));
            Assert.AreEqual(4, OdderThanRest.OddOne(new List<int> {2, 16, 98, 10, 13, 78}));
            Assert.AreEqual(4, OdderThanRest.OddOne(new List<int> {4, -8, 98, -12, -7, 90, 100}));
            Assert.AreEqual(-1, OdderThanRest.OddOne(new List<int> {2, 4, 6, 8}));
        }
    }
}