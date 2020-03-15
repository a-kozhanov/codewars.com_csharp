using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun3LateRideTests
    {
        [Test]
        public void TestCase()
        {
            var kata = new SimpleFun3LateRide();
            Assert.AreEqual(4, kata.LateRide(240), "");
            Assert.AreEqual(14, kata.LateRide(808), "");
            Assert.AreEqual(19, kata.LateRide(1439), "");
            Assert.AreEqual(0, kata.LateRide(0), "");
            Assert.AreEqual(5, kata.LateRide(23), "");
            Assert.AreEqual(8, kata.LateRide(8), "");
        }
    }
}