using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class YouGotChangeTests
    {
        [TestFixture]
        public class Test
        {
            [Test]
            public void BasicTest()
            {
                Assert.AreEqual(new int[] {0, 1, 1, 0, 1, 3}, YouGotChange.GiveChange(365));
                Assert.AreEqual(new int[] {2, 1, 1, 0, 0, 2}, YouGotChange.GiveChange(217));
            }
        }
    }
}