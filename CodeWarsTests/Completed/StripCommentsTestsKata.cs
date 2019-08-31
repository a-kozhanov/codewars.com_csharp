using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataStripCommentsTests
    {
        [Test]
        public void StripComments()
        {
            Assert.AreEqual(
                "apples, pears\ngrapes\nbananas",
                StripCommentsKata.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

            Assert.AreEqual("a\nc\nd", StripCommentsKata.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

        }
    }
}