using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataTripleTrouble8Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("ttlheoiscstk", KataTripleTrouble8.TripleTrouble("this", "test", "lock"));
            Assert.AreEqual("abcabc", KataTripleTrouble8.TripleTrouble("aa", "bb", "cc"));
            Assert.AreEqual("Batman", KataTripleTrouble8.TripleTrouble("Bm", "aa", "tn"));
            Assert.AreEqual("LexLuthor", KataTripleTrouble8.TripleTrouble("LLh", "euo", "xtr"));
        }
    }
}