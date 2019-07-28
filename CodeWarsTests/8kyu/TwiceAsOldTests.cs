using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TwiceAsOldTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(30, KataTwiceAsOld.TwiceAsOld(30, 0));
            Assert.AreEqual(16, KataTwiceAsOld.TwiceAsOld(30, 7));
            Assert.AreEqual(15, KataTwiceAsOld.TwiceAsOld(45, 30));
        }
    }
}