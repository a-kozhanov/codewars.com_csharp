using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ComfortableWordsTests
    {
        private KataComfortableWords kata = new KataComfortableWords();

        [Test]
        public void ConfortableWords()
        {
            Assert.AreEqual(true, kata.ComfortableWord("yams"), "yams is a confortable word");
            Assert.AreEqual(true, kata.ComfortableWord("odor"), "odor is a confortable word");
            Assert.AreEqual(true, kata.ComfortableWord("their"), "their is a confortable word");
        }

        [Test]
        public void NotConfortableWords()
        {
            Assert.AreEqual(false, kata.ComfortableWord("leisure"), "leisure is NOT a confortable word");
            Assert.AreEqual(false, kata.ComfortableWord("touts"), "touts is NOT a confortable word");
            Assert.AreEqual(false, kata.ComfortableWord("test"), "test is NOT a confortable word");
        }
    }
}