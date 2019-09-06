using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountOddNumbersTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(7, CountOddNumbers.OddCount(15));
            Assert.AreEqual(7511, CountOddNumbers.OddCount(15023));
        }
    }
}