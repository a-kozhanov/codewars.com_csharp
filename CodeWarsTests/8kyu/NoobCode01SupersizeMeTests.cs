using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NoobCode01SupersizeMeTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(96, NoobCode01SupersizeMe.SuperSize(69));
            Assert.AreEqual(531, NoobCode01SupersizeMe.SuperSize(513));
            Assert.AreEqual(7210, NoobCode01SupersizeMe.SuperSize(2017));
            Assert.AreEqual(441, NoobCode01SupersizeMe.SuperSize(414));
            Assert.AreEqual(987610, NoobCode01SupersizeMe.SuperSize(608719));
            Assert.AreEqual(987654321, NoobCode01SupersizeMe.SuperSize(123456789));
            Assert.AreEqual(710000000000, NoobCode01SupersizeMe.SuperSize(700000000001));
            Assert.AreEqual(666666, NoobCode01SupersizeMe.SuperSize(666666));
            Assert.AreEqual(2, NoobCode01SupersizeMe.SuperSize(2));
        }
    }
}