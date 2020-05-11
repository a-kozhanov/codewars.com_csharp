using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertingIntegerToCurrencyFormatTests
    {
        [Test]
        [TestCase(100000, ExpectedResult="100,000")]
        [TestCase(5678545, ExpectedResult="5,678,545")]
        public static string FixedTest(int price)
        {
            return ConvertingIntegerToCurrencyFormat.ToCurrency(price);
        }
    }
}