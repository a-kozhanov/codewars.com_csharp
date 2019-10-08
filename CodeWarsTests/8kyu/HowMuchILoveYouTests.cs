using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HowMuchILoveYouTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("I love you", KataHowMuchILoveYou.HowMuchILoveYou(7));
            Assert.AreEqual("a lot", KataHowMuchILoveYou.HowMuchILoveYou(3));
            Assert.AreEqual("not at all", KataHowMuchILoveYou.HowMuchILoveYou(6));
        }
    }
}