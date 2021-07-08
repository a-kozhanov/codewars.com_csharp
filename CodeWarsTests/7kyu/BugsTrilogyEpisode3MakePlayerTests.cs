using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BugsTrilogyEpisode3MakePlayerTests
    {
        [Test]
        public void SampleTest()
        {
            BugsTrilogyEpisode3MakePlayer player = new BugsTrilogyEpisode3MakePlayer("Player", "Right Winger", 25, 75, 90, 65);
            Assert.AreEqual("Player", player.Name);
            Assert.AreEqual("Right Winger", player.Position);
            Assert.AreEqual(25, player.Age);
            Assert.AreEqual(75, player.Dribbling);
            Assert.AreEqual(90, player.Pass);
            Assert.AreEqual(65, player.Shoot);
        }
    }
}