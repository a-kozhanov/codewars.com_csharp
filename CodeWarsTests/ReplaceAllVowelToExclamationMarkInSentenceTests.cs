using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReplaceAllVowelToExclamationMarkInSentenceTests
    {
        [Test, Description("Basic Tests")]
        public void BasicTest()
        {
            Assert.AreEqual("H!!", ReplaceAllVowelToExclamationMarkInSentence.Replace("Hi!"));
            Assert.AreEqual("!H!! H!!", ReplaceAllVowelToExclamationMarkInSentence.Replace("!Hi! Hi!"));
            Assert.AreEqual("!!!!!", ReplaceAllVowelToExclamationMarkInSentence.Replace("aeiou"));
            Assert.AreEqual("!BCD!", ReplaceAllVowelToExclamationMarkInSentence.Replace("ABCDE"));
        }
    }
}