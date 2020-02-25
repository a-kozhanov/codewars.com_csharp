using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkingTestingAandBTests
    {
        [Test]
        public void BasicTests()
        {
            //a+b?
            Assert.AreEqual(1, new ThinkingTestingAandB().Testit(0, 1));
            Assert.AreEqual(3, new ThinkingTestingAandB().Testit(1, 2));
            Assert.AreEqual(30, new ThinkingTestingAandB().Testit(10, 20));
            //a*b?
            Assert.AreEqual(1, new ThinkingTestingAandB().Testit(1, 1));
            Assert.AreEqual(3, new ThinkingTestingAandB().Testit(1, 3));
            //Click "Attempt" try more testcase...
        }
    }
}