using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SortAndStarTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("b***i***t***c***o***i***n", SortAndStar.TwoSort(new[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" }));
            Assert.AreEqual("a***r***e", SortAndStar.TwoSort(new[] { "turns", "out", "random", "test", "cases", "are", "easier", "than", "writing", "out", "basic", "ones" }));
        }
    }
}