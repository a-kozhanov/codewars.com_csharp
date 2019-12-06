using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OnlineRPGPlayerToQualifyingStageTests
    {
        [Test]
        public static void Test64()
        {
            Assert.AreEqual(OnlineRPGPlayerToQualifyingStage.PlayerRankUp(64), false);
        }

        [Test]
        public static void Test101()
        {
            Assert.AreEqual(OnlineRPGPlayerToQualifyingStage.PlayerRankUp(101), 
                "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.");
        }
    }
}