using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperBasicFunctionFixerTests
    {
        [Test]
        [TestCase(5, ExpectedResult = 10)]
        [TestCase(0, ExpectedResult = 5)]
        [TestCase(-5, ExpectedResult = 0)]
        public static int FixedTest(int num)
        {
            return GrasshopperBasicFunctionFixer.AddFive(num);
        }
    }
}