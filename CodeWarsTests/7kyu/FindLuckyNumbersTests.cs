using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindLuckyNumbersTests
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual(new int[] {7, 70, 17},
                FindLuckyNumbers.FilterLucky(new int[] {1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17}));

            Assert.AreEqual(new int[] { }, FindLuckyNumbers.FilterLucky(new int[] { }));
        }
    }
}