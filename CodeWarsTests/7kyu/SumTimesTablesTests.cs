using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumTimesTablesTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(30, SumTimesTables.SumTimesTable(new List<int> {2, 3}, 1, 3));
            Assert.AreEqual(9, SumTimesTables.SumTimesTable(new List<int> {1, 3, 5}, 1, 1));
            Assert.AreEqual(495, SumTimesTables.SumTimesTable(new List<int> {1, 3, 5}, 1, 10));
        }
    }
}