using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindTwinsTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(1, FindTwins.Elimination(new int[] {2, 5, 34, 1, 22, 1}));
            Assert.AreEqual(2, FindTwins.Elimination(new int[] {2, 2, 34, 1, 22}));
            Assert.AreEqual(null, FindTwins.Elimination(new int[] {2, 5, 34, 1, 22}));
        }
    }
}