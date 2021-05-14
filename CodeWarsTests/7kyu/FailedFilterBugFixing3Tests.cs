using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FailedFilterBugFixing3Tests
    {
        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual("test", FailedFilterBugFixing3.FilterNumbers("test123"));
            Assert.AreEqual("abc", FailedFilterBugFixing3.FilterNumbers("a1b2c3"));
            Assert.AreEqual("aabbccdd", FailedFilterBugFixing3.FilterNumbers("aa1bb2cc3dd"));
        }
    }
}