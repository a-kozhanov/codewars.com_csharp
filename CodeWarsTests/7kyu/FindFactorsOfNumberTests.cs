using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindFactorsOfNumberTests
    {
        [Test]
        [TestCase(54, ExpectedResult = new int[] {54, 27, 18, 9, 6, 3, 2, 1})]
        [TestCase(9, ExpectedResult = new int[] {9, 3, 1})]
        public static int[] FixedTest(int num)
        {
            return FindFactorsOfNumber.Factors(num);
        }
    }
}