using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PriceOfMangoesTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(6, PriceOfMangoes.Mango(3, 3));
            Assert.AreEqual(30, PriceOfMangoes.Mango(9, 5));
        }
    }
}