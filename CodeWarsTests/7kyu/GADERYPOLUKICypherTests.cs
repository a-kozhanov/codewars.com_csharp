using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GADERYPOLUKICypherTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Gug hgs g cgt", GADERYPOLUKICypher.Encode("Ala has a cat"));
            Assert.AreEqual("GBCE", GADERYPOLUKICypher.Encode("ABCD"));
            Assert.AreEqual("Gug hgs g cgt", GADERYPOLUKICypher.Encode("Ala has a cat"));
            Assert.AreEqual("agedyropulik", GADERYPOLUKICypher.Encode("gaderypoluki"));
            Assert.AreEqual("Ala has a cat", GADERYPOLUKICypher.Decode("Gug hgs g cgt"));
            Assert.AreEqual("gaderypoluki", GADERYPOLUKICypher.Decode("agedyropulik"));
            Assert.AreEqual("ABCD", GADERYPOLUKICypher.Decode("GBCE"));
        }
    }
}