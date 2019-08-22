using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExtraPerfectNumbersTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { 1, 3 }, ExtraPerfectNumbers.ExtraPerfect(3));
            Assert.AreEqual(new int[] { 1, 3, 5 }, ExtraPerfectNumbers.ExtraPerfect(5));
            Assert.AreEqual(new int[] { 1, 3, 5, 7 }, ExtraPerfectNumbers.ExtraPerfect(7));
            Assert.AreEqual(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27 }, ExtraPerfectNumbers.ExtraPerfect(28));
            Assert.AreEqual(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 }, ExtraPerfectNumbers.ExtraPerfect(39));
        }
    }
}