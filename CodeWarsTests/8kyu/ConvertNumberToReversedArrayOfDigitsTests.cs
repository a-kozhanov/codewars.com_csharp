using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertNumberToReversedArrayOfDigitsTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new long[] {1, 3, 2, 5, 3}, ConvertNumberToReversedArrayOfDigits.Digitize(35231));
        }
    }
}