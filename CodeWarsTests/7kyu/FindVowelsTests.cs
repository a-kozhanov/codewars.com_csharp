using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindVowelsTests
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(new int[] { }, FindVowels.VowelIndices("mmm"));
            Assert.AreEqual(new int[] {1, 5}, FindVowels.VowelIndices("apple"));
            Assert.AreEqual(new int[] {2, 4}, FindVowels.VowelIndices("super"));
            Assert.AreEqual(new int[] {1, 3, 6}, FindVowels.VowelIndices("orange"));
            Assert.AreEqual(new int[] {2, 4, 7, 9, 12, 14, 16, 19, 21, 24, 25, 27, 29, 31, 32, 33},
                FindVowels.VowelIndices("supercalifragilisticexpialidocious"));
        }
    }
}