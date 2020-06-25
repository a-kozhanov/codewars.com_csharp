using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReversingFunTests
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual("201", ReversingFun.FlipNumber("012"));
            Assert.AreEqual("504132", ReversingFun.FlipNumber("012345"));
            Assert.AreEqual("9081726354", ReversingFun.FlipNumber("0123456789"));
        }
    }
}