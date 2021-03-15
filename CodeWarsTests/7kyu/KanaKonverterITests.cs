using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KanaKonverterITests
    {
        [Test]
        public void romajiToHira()
        {
            Assert.AreEqual("あえいおう", KanaKonverterI.vowels("aeiou", "hiragana"));
        }

        [Test]
        public void romajiToKata()
        {
            Assert.AreEqual("アエイオウ", KanaKonverterI.vowels("aeiou", "katakana"));
        }

        [Test]
        public void romajiToRomaji()
        {
            Assert.AreEqual("aeiou", KanaKonverterI.vowels("aeiou", "romaji"));
        }

        [Test]
        public void hiraToHira()
        {
            Assert.AreEqual("あえいおう", KanaKonverterI.vowels("あえいおう", "hiragana"));
        }

        [Test]
        public void hiraToKata()
        {
            Assert.AreEqual("アエイオウ", KanaKonverterI.vowels("あえいおう", "katakana"));
        }

        [Test]
        public void hiraToRomaji()
        {
            Assert.AreEqual("aeiou", KanaKonverterI.vowels("あえいおう", "romaji"));
        }

        [Test]
        public void kataToHira()
        {
            Assert.AreEqual("あえいおう", KanaKonverterI.vowels("アエイオウ", "hiragana"));
        }

        [Test]
        public void kataToKata()
        {
            Assert.AreEqual("アエイオウ", KanaKonverterI.vowels("アエイオウ", "katakana"));
        }

        [Test]
        public void kataToRomaji()
        {
            Assert.AreEqual("aeiou", KanaKonverterI.vowels("アエイオウ", "romaji"));
        }

        [Test]
        public void noInput()
        {
            Assert.AreEqual("", KanaKonverterI.vowels("", "romaji"));
        }

        [Test]
        public void emptyParameters()
        {
            Assert.AreEqual("", KanaKonverterI.vowels("", ""));
        }

        [Test]
        public void Uppercase()
        {
            Assert.AreEqual("aAeEoOUu", KanaKonverterI.vowels("aAeEoOUu", "romaji"));
        }
    }
}