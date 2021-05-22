using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BuildingBlocksTests
    {
        [Test]
        public static void ExampleTest()
        {
            BuildingBlocks.Block b = new BuildingBlocks.Block(new int[] {2, 2, 2});
            Assert.AreEqual(2, b.GetWidth());
            Assert.AreEqual(2, b.GetLength());
            Assert.AreEqual(2, b.GetHeight());
            Assert.AreEqual(8, b.GetVolume());
            Assert.AreEqual(24, b.GetSurfaceArea());
        }
    }
}