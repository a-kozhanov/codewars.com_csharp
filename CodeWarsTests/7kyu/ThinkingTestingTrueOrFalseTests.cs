using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkingTestingTrueOrFalseTests
    {
        [Test]
        public void TestCase()
        {
            //Ookokokk?
            Assert.AreEqual(0, new ThinkingTestingTrueOrFalse().Testit(0), "");
            Assert.AreEqual(1, new ThinkingTestingTrueOrFalse().Testit(1), "");
            //return n-1 ?
            Assert.AreEqual(1, new ThinkingTestingTrueOrFalse().Testit(2), "");
            Assert.AreEqual(2, new ThinkingTestingTrueOrFalse().Testit(3), "");
            //return n/3 ?
            Assert.AreEqual(1, new ThinkingTestingTrueOrFalse().Testit(4), "");
            Assert.AreEqual(2, new ThinkingTestingTrueOrFalse().Testit(5), "");
            Assert.AreEqual(2, new ThinkingTestingTrueOrFalse().Testit(6), "");
            Assert.AreEqual(3, new ThinkingTestingTrueOrFalse().Testit(7), "");
            //All of the above answers are wrong 
            Assert.AreEqual(1, new ThinkingTestingTrueOrFalse().Testit(8), "");
            Assert.AreEqual(2, new ThinkingTestingTrueOrFalse().Testit(9), "");
            Assert.AreEqual(2, new ThinkingTestingTrueOrFalse().Testit(10), "");
            Assert.AreEqual(3, new ThinkingTestingTrueOrFalse().Testit(100), "");
            Assert.AreEqual(6, new ThinkingTestingTrueOrFalse().Testit(1000), "");
            Assert.AreEqual(5, new ThinkingTestingTrueOrFalse().Testit(10000), "");
            //return what ? thinking and testing...
        }
    }
}