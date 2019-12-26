using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MilesPerGallonToKilometersPerLiterTests
    {
        [Test]
        public void Basic_Tests()
        {
            Assert.AreEqual(4.25, MilesPerGallonToKilometersPerLiter.Converter(12));
            Assert.AreEqual(8.50, MilesPerGallonToKilometersPerLiter.Converter(24));
            Assert.AreEqual(12.74, MilesPerGallonToKilometersPerLiter.Converter(36));
        }
    }
}