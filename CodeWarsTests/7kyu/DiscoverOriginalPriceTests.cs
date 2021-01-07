using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DiscoverOriginalPriceTests
    {
        [Test]
        public void GivenDiscount75Rate25Returns100()
        {
            Assert.AreEqual(100.00M, KataDiscoverOriginalPrice.DiscoverOriginalPrice(75M, 25M));
        }
    }
}