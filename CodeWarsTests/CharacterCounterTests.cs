using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CharacterCounterTests
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual(true, CharacterCounter.ValidateWord("abcabc"), "The word was: \"abcabc\"");
            Assert.AreEqual(true, CharacterCounter.ValidateWord("Abcabc"), "The word was: \"Abcabc\"");
            Assert.AreEqual(true, CharacterCounter.ValidateWord("abc123"), "The word was: \"abc123\"");
            Assert.AreEqual(false, CharacterCounter.ValidateWord("abcabcd"), "The word was: \"abcabcd\"");
            Assert.AreEqual(true, CharacterCounter.ValidateWord("abc!abc!"), "The word was: \"abc!abc!\"");
            Assert.AreEqual(false, CharacterCounter.ValidateWord("abc:abc"), "The word was: \"abc:abc\"");
        }
    }
}