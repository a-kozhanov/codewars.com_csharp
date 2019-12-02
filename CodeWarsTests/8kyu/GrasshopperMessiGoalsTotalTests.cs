using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    public class GrasshopperMessiGoalsTotalTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(GrasshopperMessiGoalsTotal.la_liga_goals, 43);
            Assert.AreEqual(GrasshopperMessiGoalsTotal.champions_league_goals, 10);
            Assert.AreEqual(GrasshopperMessiGoalsTotal.copa_del_rey_goals, 5);
            Assert.AreEqual(GrasshopperMessiGoalsTotal.total_goals, 58);
        }
    }
}