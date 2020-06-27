using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PartialWordSearchingTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new string[] {"ab", "abc", "zab"},
                PartialWordSearching.WordSearch("ab", new string[] {"za", "ab", "abc", "zab", "zbc"}));

            Assert.AreEqual(new string[] {"ab", "abc", "zab"},
                PartialWordSearching.WordSearch("aB", new string[] {"za", "ab", "abc", "zab", "zbc"}));

            Assert.AreEqual(new string[] {"aB", "Abc", "zAB"},
                PartialWordSearching.WordSearch("ab", new string[] {"za", "aB", "Abc", "zAB", "zbc"}));

            Assert.AreEqual(new string[] {"Empty"},
                PartialWordSearching.WordSearch("abcd", new string[] {"za", "aB", "Abc", "zAB", "zbc"}));
        }
    }
}