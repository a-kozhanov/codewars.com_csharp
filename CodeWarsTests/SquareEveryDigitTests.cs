using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SquareEveryDigitTests
    {
        [Test]
        public void SquareDigitsTest()
        {
            Assert.AreEqual(811181, SquareEveryDigit.SquareDigits(9119));
        }
    }
}