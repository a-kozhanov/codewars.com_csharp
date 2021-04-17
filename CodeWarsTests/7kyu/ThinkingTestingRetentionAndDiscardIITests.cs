using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkingTestingRetentionAndDiscardIITests
    {
        [Test]
        public void TestCase()
        {
            var kata = new ThinkingTestingRetentionAndDiscardII();
            //Discard the false and retain the true
            Assert.AreEqual("", kata.Testit("1", 0), "");
            Assert.AreEqual("1", kata.Testit("1", 1), "");
            Assert.AreEqual("", kata.Testit("11", 0), "");
            Assert.AreEqual("1", kata.Testit("11", 1), "");
            Assert.AreEqual("1", kata.Testit("11", 2), "");
            Assert.AreEqual("11", kata.Testit("11", 3), "");
            Assert.AreEqual("1", kata.Testit("11", 4), "");
            Assert.AreEqual("", kata.Testit("1234", 0), "");
            Assert.AreEqual("1", kata.Testit("1234", 1), "");
            Assert.AreEqual("1", kata.Testit("1234", 2), "");
            Assert.AreEqual("12", kata.Testit("1234", 3), "");
            Assert.AreEqual("1", kata.Testit("1234", 4), "");
            Assert.AreEqual("13", kata.Testit("1234", 5), "");
            Assert.AreEqual("12", kata.Testit("1234", 6), "");
            //click "Submit" try more testcase...
        }
    }
}