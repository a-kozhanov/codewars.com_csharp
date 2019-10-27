using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SentenceSmashTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("hello", SentenceSmash.Smash(new string[] { "hello" }));
            Assert.AreEqual("hello world", SentenceSmash.Smash(new string[] { "hello", "world" }));
            Assert.AreEqual("hello amazing world", SentenceSmash.Smash(new string[] { "hello", "amazing", "world" }));
            Assert.AreEqual("this is a really long sentence", SentenceSmash.Smash(new string[] { "this", "is", "a", "really", "long", "sentence" }));
            Assert.AreEqual("", SentenceSmash.Smash(new string[] { "" }));
        }
    }
}