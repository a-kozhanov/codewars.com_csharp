using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BuildingWallWithBricksTests
    {
        [Test]
        public void SimpleTests()
        {
            BuildingWallWithBricks brick = new BuildingWallWithBricks();
            var case1 = brick.CalculateBricksCount(180, 45);
            var case2 = brick.CalculateBricksCount(60, 5);
            Assert.AreEqual("21L6M6S", case1);
            Assert.AreEqual("1L", case2);
        }
    }
}