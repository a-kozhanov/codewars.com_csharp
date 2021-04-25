using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FrugalPizzaTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(0.11, FrugalPizza.PizzaPrice(7, 4.30));
            Assert.AreEqual(0.09, FrugalPizza.PizzaPrice(9, 5.95));
            Assert.AreEqual(0.07, FrugalPizza.PizzaPrice(12, 7.90));
        }
    }
}