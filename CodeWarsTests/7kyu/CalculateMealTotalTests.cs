using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CalculateMealTotalTests
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(5.75, CalculateMealTotal.CalculateTotal(5.00, 5, 10));
            Assert.AreEqual(45.10, CalculateMealTotal.CalculateTotal(36.97, 7, 15));
        }
    }
}