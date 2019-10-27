using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HowManyLightsabersDoYouOwnTests
    {
        [Test]
        public static void Adam()
        {
            Assert.AreEqual(0, KataHowManyLightsabersDoYouOwn.HowManyLightsabersDoYouOwn("Adam"));
        }

        [Test]
        public static void Zach()
        {
            Assert.AreEqual(18, KataHowManyLightsabersDoYouOwn.HowManyLightsabersDoYouOwn("Zach"));
        }
    }
}