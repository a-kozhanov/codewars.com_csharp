using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConsecutiveDucksTests
    {
        [Test]
        public void SmallValues()
        {
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(69));
            Assert.AreEqual(false, KataConsecutiveDucks.ConsecutiveDucks(8));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(57));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(6));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(13));
            Assert.AreEqual(false, KataConsecutiveDucks.ConsecutiveDucks(16));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(91));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(75));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(38));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(25));
            Assert.AreEqual(false, KataConsecutiveDucks.ConsecutiveDucks(32));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(65));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(13));
            Assert.AreEqual(false, KataConsecutiveDucks.ConsecutiveDucks(16));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(99));
        }

        [Test]
        public void MediumValues()
        {
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(522));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(974));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(755));
            Assert.AreEqual(false, KataConsecutiveDucks.ConsecutiveDucks(512));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(739));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(1006));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(838));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(1092));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(727));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(648));
            Assert.AreEqual(false, KataConsecutiveDucks.ConsecutiveDucks(1024));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(851));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(541));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(1011));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(822));
        }

        [Test]
        public void LargeValues()
        {
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(382131));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(118070));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(17209));
            Assert.AreEqual(false, KataConsecutiveDucks.ConsecutiveDucks(32768));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(161997));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(400779));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(198331));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(325482));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(88441));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(648));
            Assert.AreEqual(false, KataConsecutiveDucks.ConsecutiveDucks(65536));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(323744));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(183540));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(65271));
            Assert.AreEqual(true, KataConsecutiveDucks.ConsecutiveDucks(5263987));
        }
    }
}