using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RegexpBasicsIsItDigitTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(false, RegexpBasicsIsItDigit.Digit(""));
            Assert.AreEqual(true, RegexpBasicsIsItDigit.Digit("7"));
            Assert.AreEqual(false, RegexpBasicsIsItDigit.Digit(" "));
            Assert.AreEqual(false, RegexpBasicsIsItDigit.Digit("a"));
            Assert.AreEqual(false, RegexpBasicsIsItDigit.Digit("a5"));
            Assert.AreEqual(false, RegexpBasicsIsItDigit.Digit("14"));
            Assert.AreEqual(false, RegexpBasicsIsItDigit.Digit("1\n"));
            Assert.AreEqual(false, RegexpBasicsIsItDigit.Digit("1\n0"));
        }
    }
}