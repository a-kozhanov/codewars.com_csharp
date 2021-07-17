using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindingRemainderWithoutUsingOperatorTests
    {
        [Test]
        [TestCase(3, 2, ExpectedResult = 1)]
        [TestCase(19, 2, ExpectedResult = 1)]
        [TestCase(10, 2, ExpectedResult = 0)]
        [TestCase(34, 7, ExpectedResult = 6)]
        [TestCase(27, 5, ExpectedResult = 2)]
        public static int FixedTest(int D, int d)
        {
            return FindingRemainderWithoutUsingOperator.Remainder(D, d);
        }
    }
}