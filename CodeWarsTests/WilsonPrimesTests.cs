using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WilsonPrimesTests
    {
        [Test]
        [TestCase(5, ExpectedResult = true)]
        [TestCase(9, ExpectedResult = false)]
        [TestCase(6, ExpectedResult = false)]
        public static bool FixedTest(int p)
        {
            return WilsonPrimes.AmIWilson(p);
        }
    }
}