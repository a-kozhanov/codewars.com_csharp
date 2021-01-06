using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    public class CountOnesTests
    {
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(10, ExpectedResult = 2)]
        [TestCase(21, ExpectedResult = 3)]
        [TestCase(2048, ExpectedResult = 1)]
        [TestCase(-1, ExpectedResult = 32)]
        [TestCase(-2, ExpectedResult = 31)]
        [TestCase(-10, ExpectedResult = 30)]
        [TestCase(-21, ExpectedResult = 30)]
        [TestCase(-2048, ExpectedResult = 21)]
        public int Example(int x) => CountOnes.HammingWeight(x);
    }
}