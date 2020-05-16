using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RemoveNoiseFromStringTests
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual("", RemoveNoiseFromString.removeNoise("%$&/#·@|º\\ª"),
                "You failed the test for '%$&/#·@|º\\ª'. (Please note that in c# special characters are displayed as '?' in the error screen)");
            Assert.AreEqual("hello world", RemoveNoiseFromString.removeNoise("h%e&·%$·llo w&%or&$l·$%d"),
                "You failed the test for 'h%e&·%$·llo w&%or&$l·$%d'.");
            Assert.AreEqual("hello coding for everyone",
                RemoveNoiseFromString.removeNoise("he%$·ll@o c$&%odi%&ng for ev|#·ery&$$#$on%$·e"),
                "You failed the test for 'he%$·ll@o c$&%odi%&ng for ev|#·ery&$$#$on%$·e'.");
            Assert.AreEqual("codewars rocks", RemoveNoiseFromString.removeNoise("c|o@$%de%w@a·$r%s &rºocªks"),
                "You failed the test for 'c|o@$%de%w@a·$r%s &rºocªks'.(Please note that in c# special characters are displayed as '?' in the error screen)");
        }
    }
}