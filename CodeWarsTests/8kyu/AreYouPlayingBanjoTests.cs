using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AreYouPlayingBanjoTests
    {
        [Test]
        public static void Martin()
        {
            Assert.AreEqual("Martin does not play banjo", KataAreYouPlayingBanjo.AreYouPlayingBanjo("Martin"));
        }

        [Test]
        public static void Rikke()
        {
            Assert.AreEqual("Rikke plays banjo", KataAreYouPlayingBanjo.AreYouPlayingBanjo("Rikke"));
        }
    }
}