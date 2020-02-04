using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WhatsMyGolfScoreTests
    {
        [Test, Description("Should calculate sample inputs")]
        public void SampleTest()
        {
            Assert.That(WhatsMyGolfScore.GolfScoreCalculator("453454444344544443", "354445334534445348"),
                Is.EqualTo(3));
            Assert.That(WhatsMyGolfScore.GolfScoreCalculator("333333333333333333", "444444444444444444"),
                Is.EqualTo(18));
        }
    }
}