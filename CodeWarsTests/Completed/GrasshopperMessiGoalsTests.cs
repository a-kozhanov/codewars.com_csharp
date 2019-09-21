using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperMessiGoalsTests
    {
        [Test]
        public void NoGoals()
        {
            Assert.AreEqual(GrasshopperMessiGoals.GetGoals(0, 0, 0), 0);
        }
        [Test]
        public void FiftyEightGoals()
        {
            Assert.AreEqual(GrasshopperMessiGoals.GetGoals(43, 10, 5), 58);
        }
    }
}