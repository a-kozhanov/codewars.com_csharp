using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkingTestingIncompleteStringTests
    {
        [Test]
        public void TestCase()
        {

            //return s ?
            Assert.AreEqual("", new ThinkingTestingIncompleteString().Testit(""), "");
            Assert.AreEqual("a", new ThinkingTestingIncompleteString().Testit("a"), "");
            Assert.AreEqual("b", new ThinkingTestingIncompleteString().Testit("b"), "");
            //return s.Substring(0,1) ?
            Assert.AreEqual("a", new ThinkingTestingIncompleteString().Testit("aa"), "");
            Assert.AreEqual("a", new ThinkingTestingIncompleteString().Testit("ab"), "");
            Assert.AreEqual("b", new ThinkingTestingIncompleteString().Testit("bc"), "");
            //return s.Substring(0,s.Length/2) ?
            Assert.AreEqual("aa", new ThinkingTestingIncompleteString().Testit("aaaa"), "");
            Assert.AreEqual("aaa", new ThinkingTestingIncompleteString().Testit("aaaaaa"), "");
            //click "Submit" try more testcase...
        }
    }
}