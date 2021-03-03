using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountingPowerSetsTests
    {
        [Test, Description("Sample tests")]
        public void SampleTest()
        {
            Assert.AreEqual(1, CountingPowerSets.Powers(new int[] { }));
            Assert.AreEqual(2, CountingPowerSets.Powers(new int[] {1}));
            Assert.AreEqual(4, CountingPowerSets.Powers(new int[] {1, 2}));
            Assert.AreEqual(16, CountingPowerSets.Powers(new int[] {1, 2, 3, 4}));
        }
    }
}