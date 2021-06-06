using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReverseBitsInAnIntegerTests
    {
        [Test(Description = "Sample tests")]
        public void SampleTests()
        {
            Assert.AreEqual(267, ReverseBitsInAnInteger.ReverseBits(417));
            Assert.AreEqual(417, ReverseBitsInAnInteger.ReverseBits(267));
            Assert.AreEqual(0, ReverseBitsInAnInteger.ReverseBits(0));
            Assert.AreEqual(1087, ReverseBitsInAnInteger.ReverseBits(2017));
            Assert.AreEqual(1023, ReverseBitsInAnInteger.ReverseBits(1023));
            Assert.AreEqual(1, ReverseBitsInAnInteger.ReverseBits(1024));
            Assert.AreEqual(long.MaxValue, ReverseBitsInAnInteger.ReverseBits(long.MaxValue));
        }
    }
}