using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HexToDecimalTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, HexToDecimal.HexToDec("1"));
            Assert.AreEqual(10, HexToDecimal.HexToDec("a"));
            Assert.AreEqual(16, HexToDecimal.HexToDec("10"));
            Assert.AreEqual(255, HexToDecimal.HexToDec("FF"));
            Assert.AreEqual(-12, HexToDecimal.HexToDec("-C"));
        }
    }
}