using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AcrosticReaderTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("JACK", AcrosticReader.ReadOut(new string[] {"Jolly", "Amazing", "Courteous", "Keen"}));
            Assert.AreEqual("MEG", AcrosticReader.ReadOut(new string[] {"Marvelous", "Excellent", "Gifted"}));
        }
    }
}