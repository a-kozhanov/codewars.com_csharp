using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CalculateIntegralTests
    {
        [Test]
        [TestCase(0, 1, 0, 1, ExpectedResult = 1)]
        [TestCase(0, 1, 0, 10, ExpectedResult = 10)]
        [TestCase(1, 0, 0, 4, ExpectedResult = 8)]
        [TestCase(2, 0, 2, 4, ExpectedResult = 12)]
        public static double FixedTest(double m, double b, int from, int to)
        {
            CalculateIntegral f = new CalculateIntegral();
            f.M = m;
            f.B = b;
            return f.CalcIntegral(from, to);
        }
    }
}