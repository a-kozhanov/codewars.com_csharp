using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindNthDigitOfNumberTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(5, FindNthDigitOfNumber.FindDigit(5673, 4));
            Assert.AreEqual(2, FindNthDigitOfNumber.FindDigit(129, 2));
            Assert.AreEqual(8, FindNthDigitOfNumber.FindDigit(-2825, 3));
            Assert.AreEqual(0, FindNthDigitOfNumber.FindDigit(-456, 4));
            Assert.AreEqual(0, FindNthDigitOfNumber.FindDigit(0, 20));
            Assert.AreEqual(-1, FindNthDigitOfNumber.FindDigit(65, 0));
            Assert.AreEqual(-1, FindNthDigitOfNumber.FindDigit(24, -8));
        }
    }
}