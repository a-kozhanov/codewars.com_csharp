using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PullYourWordsTogetherManTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("I am an AI.", PullYourWordsTogetherMan.Sentencify(new string[] {"i", "am", "an", "AI"}));

            Assert.AreEqual("Yes.", PullYourWordsTogetherMan.Sentencify(new string[] {"yes"}));

            Assert.AreEqual("FIELDS of CORN are to be sown.",
                PullYourWordsTogetherMan.Sentencify(new string[] {"FIELDS", "of", "CORN", "are", "to", "be", "sown"}));

            Assert.AreEqual("I'm afraid I can't let you do that.",
                PullYourWordsTogetherMan.Sentencify(new string[]
                    {"i'm", "afraid", "I", "can't", "let", "you", "do", "that"}));
        }
    }
}