using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetMiddleTest
    {
        [Test]
        public static void BasicTest()
        {
            Assert.AreEqual("es", GetMiddle.getMiddle("test"));
            Assert.AreEqual("t", GetMiddle.getMiddle("testing"));
            Assert.AreEqual("dd", GetMiddle.getMiddle("middle"));
            Assert.AreEqual("A", GetMiddle.getMiddle("A"));
        }
    }

}