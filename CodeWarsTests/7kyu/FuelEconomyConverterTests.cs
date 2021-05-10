using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FuelEconomyConverterTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(5.6, FuelEconomyConverter.mpg2lp100km(42));
            Assert.AreEqual(26.13, FuelEconomyConverter.lp100km2mpg(9));
        }
    }
}