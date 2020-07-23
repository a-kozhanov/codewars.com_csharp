using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFunShuffledArrayTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFunShuffledArray();

            Assert.AreEqual(new int[] {1, 2, 3, 6}, kata.ShuffledArray(new int[] {1, 12, 3, 6, 2}));

            Assert.AreEqual(new int[] {-5, -3, 2, 7}, kata.ShuffledArray(new int[] {1, -3, -5, 7, 2}));

            Assert.AreEqual(new int[] {-1, -1, 2, 2}, kata.ShuffledArray(new int[] {2, -1, 2, 2, -1}));

            Assert.AreEqual(new int[] {-3}, kata.ShuffledArray(new int[] {-3, -3}));
        }
    }
}