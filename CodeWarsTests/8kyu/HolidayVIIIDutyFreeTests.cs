using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HolidayVIIIDutyFreeTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(166, HolidayVIIIDutyFree.DutyFree(12, 50, 1000));
            Assert.AreEqual(294, HolidayVIIIDutyFree.DutyFree(17, 10, 500));
            Assert.AreEqual(357, HolidayVIIIDutyFree.DutyFree(24, 35, 3000));
        }
    }
}