using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataAlphabetWarTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Right side wins!", KataAlphabetWar.AlphabetWar("z"));
            Assert.AreEqual("Let's fight again!", KataAlphabetWar.AlphabetWar("zdqmwpbs"));
            Assert.AreEqual("Right side wins!", KataAlphabetWar.AlphabetWar("zzzzs"));
            Assert.AreEqual("Left side wins!", KataAlphabetWar.AlphabetWar("wwwwwwz"));
        }
    }
}