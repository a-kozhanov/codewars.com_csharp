using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HowManyTwosTests
    {
        [Test]
        [TestCase(24, ExpectedResult = 3)]
        [TestCase(17280, ExpectedResult = 7)]
        [TestCase(222222222, ExpectedResult = 1)]
        [TestCase(256, ExpectedResult = 8)]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(7, ExpectedResult = 0)]
        [TestCase(84934656, ExpectedResult = 20)]
        public static int FixedTest(int num)
        {
            return HowManyTwos.TwoCount(num);
        }
    }
}