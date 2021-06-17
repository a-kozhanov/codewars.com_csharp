using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DigitalSynesthesiaTests
    {
        [Test]
        public void OneColor()
        {
            var music = "ABC";
            var result = DigitalSynesthesia.MusicToColor(music);
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual("#414243", result[0]);
        }
    }
}