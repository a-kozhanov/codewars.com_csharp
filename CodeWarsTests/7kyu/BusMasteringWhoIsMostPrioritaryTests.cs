using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BusMasteringWhoIsMostPrioritaryTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("001000000", BusMasteringWhoIsMostPrioritary.arbitrate("001000101", 9));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("000000100", BusMasteringWhoIsMostPrioritary.arbitrate("000000101", 9));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("0000", BusMasteringWhoIsMostPrioritary.arbitrate("0000", 4));
        }
    }
}