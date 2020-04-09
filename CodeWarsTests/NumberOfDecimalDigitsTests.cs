using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NumberOfDecimalDigitsTests
    {
        [Test]
        public void Digits()
        {
            Assert.AreEqual(1, NumberOfDecimalDigits.Digits(5ul));
            Assert.AreEqual(5, NumberOfDecimalDigits.Digits(12345ul));
            Assert.AreEqual(10, NumberOfDecimalDigits.Digits(9876543210ul));
        }
    }
}