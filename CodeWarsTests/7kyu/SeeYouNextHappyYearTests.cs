using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SeeYouNextHappyYearTests
    {
        SeeYouNextHappyYear kata = new SeeYouNextHappyYear();

        [Test]
        public void BasicValues()
        {
            Assert.AreEqual(1023, kata.nextHappyYear(1001));
            Assert.AreEqual(1203, kata.nextHappyYear(1123));
            Assert.AreEqual(2013, kata.nextHappyYear(2001));
            Assert.AreEqual(2340, kata.nextHappyYear(2334));
            Assert.AreEqual(3401, kata.nextHappyYear(3331));
            Assert.AreEqual(2345, kata.nextHappyYear(2342));
            Assert.AreEqual(2013, kata.nextHappyYear(1987));
            Assert.AreEqual(2014, kata.nextHappyYear(2013));
            Assert.AreEqual(3012, kata.nextHappyYear(3000));
        }

        [Test]
        public void LargeValues()
        {
            Assert.AreEqual(5601, kata.nextHappyYear(5555));
            Assert.AreEqual(7801, kata.nextHappyYear(7712));
            Assert.AreEqual(8091, kata.nextHappyYear(8088));
            Assert.AreEqual(8901, kata.nextHappyYear(8800));
            Assert.AreEqual(9012, kata.nextHappyYear(8989));
            Assert.AreEqual(9012, kata.nextHappyYear(8977));
            Assert.AreEqual(6870, kata.nextHappyYear(6869));
            Assert.AreEqual(9012, kata.nextHappyYear(8999));
        }
    }
}