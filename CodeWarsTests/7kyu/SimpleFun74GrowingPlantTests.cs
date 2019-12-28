using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun74GrowingPlantTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun74GrowingPlant();
            Assert.AreEqual(10, kata.GrowingPlant(100, 10, 910));
            Assert.AreEqual(1, kata.GrowingPlant(10, 9, 4));
        }
    }
}