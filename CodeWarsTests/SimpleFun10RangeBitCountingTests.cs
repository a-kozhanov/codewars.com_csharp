using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun10RangeBitCountingTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun10RangeBitCounting();
            Assert.AreEqual(11, kata.RangeBitCount(2, 7), "");
            Assert.AreEqual(1, kata.RangeBitCount(0, 1), "");
            Assert.AreEqual(1, kata.RangeBitCount(4, 4), "");
        }
    }
}