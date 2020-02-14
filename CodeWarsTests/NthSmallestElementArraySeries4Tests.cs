using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NthSmallestElementArraySeries4Tests
    {
        [TestCase(02, 2, 3, 1, 2)]
        [TestCase(07, 3, 15, 20, 7, 10, 4, 3)]
        [TestCase(-1, 4, -5, -1, -6, -18)]
        [TestCase(-2, 5, -102, -16, -1, -2, -367, -9)]
        [TestCase(02, 4, 2, 169, 13, -5, 0, -1)]
        public void BasicTests(int expected, int pos, params int[] a)
        {
            Assert.That(NthSmallestElementArraySeries4.NthSmallest(a, pos), Is.EqualTo(expected));
        }
    }
}