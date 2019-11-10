using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NthPowerTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(9, NthPower.Index(new int[] { 1, 2, 3, 4 }, 2));
            Assert.AreEqual(1000000, NthPower.Index(new int[] { 1, 3, 10, 100 }, 3));
        }
    }
}