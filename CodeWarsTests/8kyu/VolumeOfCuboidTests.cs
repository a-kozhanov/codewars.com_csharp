using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class VolumeOfCuboidTests
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(4, VolumeOfCuboid.getVolumeOfCubiod(1, 2, 2));
            Assert.AreEqual(63, VolumeOfCuboid.getVolumeOfCubiod(6.3, 2, 5));
        }
    }
}