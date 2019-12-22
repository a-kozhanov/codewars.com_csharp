using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FuelCalculatorTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(5.65, FuelCalculator.FuelPrice(5, 1.23));
            Assert.AreEqual(18.40, FuelCalculator.FuelPrice(8, 2.5));
            Assert.AreEqual(27.50, FuelCalculator.FuelPrice(5, 5.6));
        }        
    }
}