using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindLongestGapTests
    {
        [Test]
        public static void FixedTests()
        {
            Assert.AreEqual(2, FindLongestGap.Gap(9), "Not working for 9");
            Assert.AreEqual(4, FindLongestGap.Gap(529), "Not working for 529");
            Assert.AreEqual(1, FindLongestGap.Gap(20), "Not working for 20");
            Assert.AreEqual(0, FindLongestGap.Gap(15), "Not working for 15");
        }
    }
}