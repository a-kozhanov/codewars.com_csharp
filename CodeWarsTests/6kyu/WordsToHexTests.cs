using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataWordsToHexTests
    {
        [Test, Description("It should handle sample test cases")]
        public void SampleTest()
        {
            Assert.AreEqual(
                new string[]
                    {"#48656c", "#6d7900", "#6e616d", "#697300", "#476172", "#616e64", "#490000", "#6c696b", "#636865"},
                KataWordsToHex.WordsToHex("Hello, my name is Gary and I like cheese."));

            Assert.AreEqual(new string[] {"#303132"}, KataWordsToHex.WordsToHex("0123456789"));

            Assert.AreEqual(new string[] {"#546869"},
                KataWordsToHex.WordsToHex("ThisIsOneLongSentenceThatConsistsOfWords"));

            Assert.AreEqual(new string[] {"#426c61", "#626c61", "#626c61", "#626c61"},
                KataWordsToHex.WordsToHex("Blah blah blah blaaaaaaaaaaaah"));

            Assert.AreEqual(new string[] {"#262626", "#242424", "#5e5e5e", "#404040", "#282928"},
                KataWordsToHex.WordsToHex("&&&&& $$$$$ ^^^^^ @@@@@ ()()()()("));
        }
    }
}