using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun261WhoseMoveTests
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual("white", SimpleFun261WhoseMove.WhoseMove("black", false));
            Assert.AreEqual("white", SimpleFun261WhoseMove.WhoseMove("white", true));
            Assert.AreEqual("black", SimpleFun261WhoseMove.WhoseMove("white", false));
        }
    }
}