using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindAllPairsTests
    {
        [TestCase(new[] {1, 2, 5, 6, 5, 2}, 2)]
        [TestCase(new[] {1, 2, 2, 20, 6, 20, 2, 6, 2}, 4)]
        [TestCase(new[] {0, 0, 0, 0, 0, 0, 0}, 3)]
        [TestCase(new[] {1000, 1000}, 1)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new[] {54}, 0)]
        public void BasicTests(int[] a, int expected)
        {
            Assert.That(FindAllPairs.Duplicates(a), Is.EqualTo(expected));
        }
    }
}