using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RiddleMadeCodeTwoSpiesTests
    {
        [Test]
        public void TestWith6()
        {
            Assert.AreEqual("3", RiddleMadeCodeTwoSpies.getAnswer("6"), "DEAD");
        }

        [Test]
        public void TestWith12()
        {
            Assert.AreEqual("6", RiddleMadeCodeTwoSpies.getAnswer("12"), "DEAD");
        }
    }
}