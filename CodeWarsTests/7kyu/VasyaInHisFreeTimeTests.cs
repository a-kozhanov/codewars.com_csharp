using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class VasyaInHisFreeTimeTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(0, VasyaInHisFreeTime.ResultString(4, "1100"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, VasyaInHisFreeTime.ResultString(5, "01010"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(6, VasyaInHisFreeTime.ResultString(8, "11101111"));
        }
    }
}