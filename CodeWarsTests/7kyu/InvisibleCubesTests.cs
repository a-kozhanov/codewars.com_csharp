using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class InvisibleCubesTests
    {
        [Test]
        [TestCase(3, ExpectedResult = 1)]
        [TestCase(5, ExpectedResult = 27)]
        public static double FixedTest(int n)
        {
            return InvisibleCubes.NotVisibleCubes(n);
        }
    }
}