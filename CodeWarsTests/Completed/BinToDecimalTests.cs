using CodeWars;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BinToDecimalTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(0, BinToDecimal.binToDec("0"));
            Assert.AreEqual(1, BinToDecimal.binToDec("1"));
            Assert.AreEqual(2, BinToDecimal.binToDec("10"));
            Assert.AreEqual(3, BinToDecimal.binToDec("11"));
            Assert.AreEqual(6, BinToDecimal.binToDec("110"));
            Assert.AreEqual(170, BinToDecimal.binToDec("10101010"));
            Assert.AreEqual(255, BinToDecimal.binToDec("11111111"));
        }
    }
}