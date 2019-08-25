using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountingDuplicatesTests
    {
        [Test]
        public void CountingDuplicatesTests1()
        {
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount(""));
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount("abcde"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, CountingDuplicates.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}