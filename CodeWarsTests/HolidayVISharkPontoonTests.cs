using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HolidayVISharkPontoonTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Alive!", HolidayVISharkPontoon.Shark(12, 50, 4, 8, true));
            Assert.AreEqual("Alive!", HolidayVISharkPontoon.Shark(12, 50, 4, 8, false));
            Assert.AreEqual("Alive!", HolidayVISharkPontoon.Shark(7, 55, 4, 16, true));
            Assert.AreEqual("Shark Bait!", HolidayVISharkPontoon.Shark(24, 0, 4, 8, true));
            Assert.AreEqual("Shark Bait!", HolidayVISharkPontoon.Shark(40, 35, 3, 20, true));
            Assert.AreEqual("Alive!", HolidayVISharkPontoon.Shark(7, 8, 3, 4, true));
            Assert.AreEqual("Shark Bait!", HolidayVISharkPontoon.Shark(7, 8, 3, 4, false));
        }
    }
}