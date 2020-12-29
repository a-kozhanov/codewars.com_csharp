using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DigitalCypherVol2Tests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("scout", DigitalCypherVol2.Decode(new int[] {20, 12, 18, 30, 21}, 1939));

            Assert.AreEqual("masterpiece",
                DigitalCypherVol2.Decode(new int[] {14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8}, 1939));
        }
    }
}