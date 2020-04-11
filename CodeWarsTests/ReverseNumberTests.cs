using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReverseNumberTests
    {
        [Test]
        public void _0_BasicTests()
        {
            var kata = new KataReverseNumber();

            Assert.AreEqual(321, kata.ReverseNumber(123));
            Assert.AreEqual(-321, kata.ReverseNumber(-123));
            Assert.AreEqual(0, kata.ReverseNumber(0));
        }
    }
}