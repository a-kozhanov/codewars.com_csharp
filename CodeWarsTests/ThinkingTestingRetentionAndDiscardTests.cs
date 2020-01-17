using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkingTestingRetentionAndDiscardTests
    {
        [Test]
        public void TestCase()
        {
            var kata = new ThinkingTestingRetentionAndDiscard();
            //In order to solve this Kata, and even discarded everything
            Assert.AreEqual(new int[] { }, kata.Testit(-1), "");
            Assert.AreEqual(new int[] { }, kata.Testit(0), "");
            Assert.AreEqual(new int[] {1}, kata.Testit(1), "");
            Assert.AreEqual(new int[] {1}, kata.Testit(2), "");
            Assert.AreEqual(new int[] {1, 3}, kata.Testit(3), "");
            Assert.AreEqual(new int[] {1}, kata.Testit(4), "");
            Assert.AreEqual(new int[] {1, 5}, kata.Testit(5), "");
            Assert.AreEqual(new int[] {1, 3}, kata.Testit(6), "");
            Assert.AreEqual(new int[] {1, 7}, kata.Testit(7), "");
            Assert.AreEqual(new int[] {1}, kata.Testit(8), "");
            Assert.AreEqual(new int[] {1, 3, 9}, kata.Testit(9), "");
            Assert.AreEqual(new int[] {1, 5}, kata.Testit(10), "");
            //click "Submit" try more testcase...
        }
    }
}