using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StringDoublesTests
    {
        [Test, Description("Basic Tests")]
        public void BasicTest()
        {
            Assert.That(StringDoubles.Doubles("abbbzz"), Is.EqualTo("ab"));
            Assert.That(StringDoubles.Doubles("zzzzykkkd"), Is.EqualTo("ykd"));
            Assert.That(StringDoubles.Doubles("abbcccdddda"), Is.EqualTo("aca"));
            Assert.That(StringDoubles.Doubles("vvvvvoiiiiin"), Is.EqualTo("voin"));
            Assert.That(StringDoubles.Doubles("rrrmooomqqqqj"), Is.EqualTo("rmomj"));
            Assert.That(StringDoubles.Doubles("xxbnnnnnyaaaaam"), Is.EqualTo("bnyam"));
        }
    }
}