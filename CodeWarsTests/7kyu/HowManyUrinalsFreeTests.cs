using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HowManyUrinalsFreeTests
    {
        [Test]
        public void SampleTests_Valid()
        {
            Assert.AreEqual(1, HowManyUrinalsFree.GetFreeUrinals("10001"));
            Assert.AreEqual(0, HowManyUrinalsFree.GetFreeUrinals("1001"));
            Assert.AreEqual(3, HowManyUrinalsFree.GetFreeUrinals("00000"));
            Assert.AreEqual(2, HowManyUrinalsFree.GetFreeUrinals("0000"));
            Assert.AreEqual(1, HowManyUrinalsFree.GetFreeUrinals("01000"));
            Assert.AreEqual(2, HowManyUrinalsFree.GetFreeUrinals("10000"));
            Assert.AreEqual(0, HowManyUrinalsFree.GetFreeUrinals("1"));
            Assert.AreEqual(1, HowManyUrinalsFree.GetFreeUrinals("0"));
            Assert.AreEqual(0, HowManyUrinalsFree.GetFreeUrinals("10"));
        }

        [Test]
        public void SampleTestsWrong()
        {
            Assert.AreEqual(-1, HowManyUrinalsFree.GetFreeUrinals("110"));
            Assert.AreEqual(-1, HowManyUrinalsFree.GetFreeUrinals("101100001"));
        }
    }
}