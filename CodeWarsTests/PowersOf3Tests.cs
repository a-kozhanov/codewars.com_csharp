using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PowersOf3Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(0, PowersOf3.LargestPower(3));
            Assert.AreEqual(1, PowersOf3.LargestPower(4));
        }
    }
}