using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WhatsRealFloorTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(0, WhatsRealFloor.GetRealFloor(1));
            Assert.AreEqual(4, WhatsRealFloor.GetRealFloor(5));
            Assert.AreEqual(13, WhatsRealFloor.GetRealFloor(15));
        }
    }
}