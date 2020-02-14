using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RegexpBasicsIsItSixBitUnsignedNumberTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(false, "".SixBitNumber());
            Assert.AreEqual(true, "0".SixBitNumber());
            Assert.AreEqual(false, "00".SixBitNumber());
            Assert.AreEqual(true, "55".SixBitNumber());
            Assert.AreEqual(true, "63".SixBitNumber());
            Assert.AreEqual(false, "64".SixBitNumber());
            Assert.AreEqual(false, "-0".SixBitNumber());
            Assert.AreEqual(false, "-5".SixBitNumber());
            Assert.AreEqual(false, "05".SixBitNumber());
            Assert.AreEqual(true, "5".SixBitNumber());
            Assert.AreEqual(false, " ".SixBitNumber());
        }
    }
}