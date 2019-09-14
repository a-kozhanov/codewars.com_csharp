using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindSmallestIntegerInArrayTest
    {
        [Test]
        [TestCase(new int[] { 78, 56, 232, 12, 11, 43 }, ExpectedResult = 11)]
        [TestCase(new int[] { 78, 56, -2, 12, 8, -33 }, ExpectedResult = -33)]
        public static int FixedTest(int[] args)
        {
            return FindSmallestIntegerInArray.FindSmallestInt(args);
        }
    }
}