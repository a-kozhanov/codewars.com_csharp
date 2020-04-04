using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RoundToNextMultipleOf5Tests
    {
        [Test]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 5)]
        [TestCase(3, ExpectedResult = 5)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(7, ExpectedResult = 10)]
        [TestCase(39, ExpectedResult = 40)]
        public static int FixedTest(int n)
        {
            return RoundToNextMultipleOf5.RoundToNext5(n);
        }
    }
}