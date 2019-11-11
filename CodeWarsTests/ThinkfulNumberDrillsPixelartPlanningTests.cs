using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkfulNumberDrillsPixelartPlanningTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, ThinkfulNumberDrillsPixelartPlanning.IsDivisible(4050, 27));
            Assert.AreEqual(false, ThinkfulNumberDrillsPixelartPlanning.IsDivisible(4066, 27));
            Assert.AreEqual(true, ThinkfulNumberDrillsPixelartPlanning.IsDivisible(10000, 20));
            Assert.AreEqual(false, ThinkfulNumberDrillsPixelartPlanning.IsDivisible(10005, 20));
            Assert.AreEqual(true, ThinkfulNumberDrillsPixelartPlanning.IsDivisible(10005, 1));
        }
    }
}