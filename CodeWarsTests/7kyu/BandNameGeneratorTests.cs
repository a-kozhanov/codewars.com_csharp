using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BandNameGeneratorTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("The Knife", KataBandNameGenerator.BandNameGenerator("knife"));
            Assert.AreEqual("Tartart", KataBandNameGenerator.BandNameGenerator("tart"));
            Assert.AreEqual("Sandlesandles", KataBandNameGenerator.BandNameGenerator("sandles"));
            Assert.AreEqual("The Bed", KataBandNameGenerator.BandNameGenerator("bed"));
        }
    }
}