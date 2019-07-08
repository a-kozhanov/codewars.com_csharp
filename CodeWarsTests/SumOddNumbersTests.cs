using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOddNumbersTests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(1, SumOddNumbers.rowSumOddNumbers(1));
            Assert.AreEqual(74088, SumOddNumbers.rowSumOddNumbers(42));
        }
    }
}