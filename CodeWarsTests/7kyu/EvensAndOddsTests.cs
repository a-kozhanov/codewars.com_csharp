using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataEvensAndOddsTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("10", KataEvensAndOdds.EvensAndOdds(2));
            Assert.AreEqual("d", KataEvensAndOdds.EvensAndOdds(13));
        }
    }
}