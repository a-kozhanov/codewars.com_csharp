using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CodewarsLeaderboardClimberTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("To beat g964's score, I must complete 5365 Beta kata and 2 8kyu kata. Dammit!",
                CodewarsLeaderboardClimber.LeaderB("g964", 36097, 20000));
            Assert.AreEqual("To beat GiacomoSorbi's score, I must complete 15 Beta kata and 2 8kyu kata.",
                CodewarsLeaderboardClimber.LeaderB("GiacomoSorbi", 23914, 23867));
            Assert.AreEqual("To beat ZozoFouchtra's score, I must complete 1330 Beta kata and 1 8kyu kata. Dammit!",
                CodewarsLeaderboardClimber.LeaderB("ZozoFouchtra", 15991, 12000));
        }
    }
}