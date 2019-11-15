using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataPluralTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, KataPlural.Plural(0), "Plural for 0");
            Assert.AreEqual(true, KataPlural.Plural(0.5), "Plural for 0.5");
            Assert.AreEqual(false, KataPlural.Plural(1), "Plural for 1");
            Assert.AreEqual(true, KataPlural.Plural(100), "Plural for 100");
            Assert.AreEqual(true, KataPlural.Plural(double.PositiveInfinity), "Plural for Infinity");
        }
    }
}