using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RegexpBasicsIsItEightBitSignedNumberTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.IsFalse("".SignedEightBitNumber());
            Assert.IsTrue("0".SignedEightBitNumber());
            Assert.IsFalse("00".SignedEightBitNumber());
            Assert.IsFalse("-0".SignedEightBitNumber());
            Assert.IsTrue("55".SignedEightBitNumber());
            Assert.IsTrue("-23".SignedEightBitNumber());
            Assert.IsFalse("042".SignedEightBitNumber());
            Assert.IsTrue("127".SignedEightBitNumber());
            Assert.IsFalse("128".SignedEightBitNumber());
            Assert.IsFalse("999".SignedEightBitNumber());
            Assert.IsTrue("-128".SignedEightBitNumber());
            Assert.IsFalse("-129".SignedEightBitNumber());
            Assert.IsFalse("-999".SignedEightBitNumber());
            Assert.IsFalse("1 ".SignedEightBitNumber());
            Assert.IsFalse(" 1".SignedEightBitNumber());
            Assert.IsFalse("1\n2".SignedEightBitNumber());
            Assert.IsFalse("+1".SignedEightBitNumber());
            Assert.IsFalse("--1".SignedEightBitNumber());
        }
    }
}