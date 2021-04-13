using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkingTestingSomethingCapitalizedTEsts
    {
        [Test]
        public void TestCase()
        {
            //return s.ToUpper() ?
            Assert.AreEqual("", new ThinkingTestingSomethingCapitalized().Testit(""), "");
            Assert.AreEqual("A", new ThinkingTestingSomethingCapitalized().Testit("a"), "");
            Assert.AreEqual("B", new ThinkingTestingSomethingCapitalized().Testit("b"), "");
            Assert.AreEqual("A A", new ThinkingTestingSomethingCapitalized().Testit("a a"), "");
            Assert.AreEqual("A B", new ThinkingTestingSomethingCapitalized().Testit("a b"), "");
            Assert.AreEqual("A B C", new ThinkingTestingSomethingCapitalized().Testit("a b c"), "");
            //click "Submit" try more testcase...
        }
    }
}