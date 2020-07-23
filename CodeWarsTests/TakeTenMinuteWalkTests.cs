using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TakeTenMinuteWalkTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true,
                TakeTenMinuteWalk.IsValidWalk(new string[] {"n", "s", "n", "s", "n", "s", "n", "s", "n", "s"}),
                "should return true");

            Assert.AreEqual(false,
                TakeTenMinuteWalk.IsValidWalk(new string[]
                    {"w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e"}), "should return false");

            Assert.AreEqual(false, TakeTenMinuteWalk.IsValidWalk(new string[] {"w"}), "should return false");

            Assert.AreEqual(false,
                TakeTenMinuteWalk.IsValidWalk(new string[] {"n", "n", "n", "s", "n", "s", "n", "s", "n", "s"}),
                "should return false");
        }
    }
}