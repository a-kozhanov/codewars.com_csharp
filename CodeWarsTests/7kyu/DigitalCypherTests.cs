using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DigitalCypherTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(new int[] {20, 12, 18, 30, 21}, DigitalCypher.Encode("scout", 1939));
            Assert.AreEqual(new int[] {14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8}, DigitalCypher.Encode("masterpiece", 1939));
       
        }
    }
}