using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ChineseZodiacTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Wood Snake", KataChineseZodiac.ChineseZodiac(1965));
            Assert.AreEqual("Earth Tiger", KataChineseZodiac.ChineseZodiac(1938));
            Assert.AreEqual("Earth Tiger", KataChineseZodiac.ChineseZodiac(1998));
            Assert.AreEqual("Fire Monkey", KataChineseZodiac.ChineseZodiac(2016));
            Assert.AreEqual("Wood Rat", KataChineseZodiac.ChineseZodiac(1924));
            Assert.AreEqual("Earth Monkey", KataChineseZodiac.ChineseZodiac(1968));
            Assert.AreEqual("Water Dog", KataChineseZodiac.ChineseZodiac(2162));
        }
    }
}