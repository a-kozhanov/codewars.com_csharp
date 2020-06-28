using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MaxDiffEasyTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(MaxDiffEasy.maxDiff(new[] {0, 1, 2, 3, 4, 5, 6}), 6);
            Assert.AreEqual(MaxDiffEasy.maxDiff(new[] {-0, 1, 2, -3, 4, 5, -6}), 11);
            Assert.AreEqual(MaxDiffEasy.maxDiff(new[] {0, 1, 2, 3, 4, 5, 16}), 16);
            Assert.AreEqual(MaxDiffEasy.maxDiff(new[] {16}), 0);
            Assert.AreEqual(MaxDiffEasy.maxDiff(new int[] { }), 0);
        }
    }
}