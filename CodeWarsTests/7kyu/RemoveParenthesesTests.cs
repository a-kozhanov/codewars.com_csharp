using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RemoveParenthesesTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("exampleexample",
                KataRemoveParentheses.RemoveParentheses("example(unwanted thing)example"));

            Assert.AreEqual("example  example",
                KataRemoveParentheses.RemoveParentheses("example (unwanted thing) example"));

            Assert.AreEqual("a e", KataRemoveParentheses.RemoveParentheses("a (bc d)e"));

            Assert.AreEqual("a", KataRemoveParentheses.RemoveParentheses("a(b(c))"));

            Assert.AreEqual("hello example  something",
                KataRemoveParentheses.RemoveParentheses("hello example (words(more words) here) something"));

            Assert.AreEqual("  ",
                KataRemoveParentheses.RemoveParentheses("(first group) (second group) (third group)"));
        }
    }
}