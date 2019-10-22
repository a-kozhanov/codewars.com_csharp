using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class UnicodeTotalTests
    {
        [Test, Description("An empty string should return zero")]
        public void ZeroTest()
        {
            Assert.AreEqual(0, UnicodeTotal.UniTotal(""));
        }

        [Test, Description("Should work with single letters")]
        public void SingleTest()
        {
            Assert.AreEqual(97, UnicodeTotal.UniTotal("a"));
            Assert.AreEqual(98, UnicodeTotal.UniTotal("b"));
            Assert.AreEqual(99, UnicodeTotal.UniTotal("c"));
            Assert.AreEqual(100, UnicodeTotal.UniTotal("d"));
            Assert.AreEqual(101, UnicodeTotal.UniTotal("e"));
        }

        [Test, Description("Should work with multiple letters")]
        public void MultipleTest()
        {
            Assert.AreEqual(291, UnicodeTotal.UniTotal("aaa"));
        }

        [Test, Description("Should work with sentence and spaces")]
        public void SentenceTest()
        {
            Assert.AreEqual(1873, UnicodeTotal.UniTotal("Mary Had A Little Lamb"));
        }
    }
}