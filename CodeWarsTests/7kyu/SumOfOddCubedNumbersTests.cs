using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOfOddCubedNumbersTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(28, SumOfOddCubedNumbers.CubeOdd(new int[] {1, 2, 3, 4}));
            Assert.AreEqual(0, SumOfOddCubedNumbers.CubeOdd(new int[] {-3, -2, 2, 3}));
        }
    }
}