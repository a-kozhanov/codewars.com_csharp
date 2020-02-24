using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOftwoLowestPositiveIntegersTests
    {
        [Test]
        public void Test1()
        {
            int[] numbers = {5, 8, 12, 19, 22};
            Assert.AreEqual(13, SumOftwoLowestPositiveIntegers.sumTwoSmallestNumbers(numbers));
        }
    }
}