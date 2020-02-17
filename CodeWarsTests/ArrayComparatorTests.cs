using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ArrayComparatorTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(4, ArrayComparator.MatchArrays(new int[] {1, 2, 3, 4, 5}, new int[] {2, 3, 4, 5, 6}));
            Assert.AreEqual(2, ArrayComparator.MatchArrays(new int[] {1, 2, 3, 4, 5}, new int[] {5, 4}));
            Assert.AreEqual(1, ArrayComparator.MatchArrays(new int[] {0, -1, 1, 4}, new int[] {-1}));
        }
    }
}