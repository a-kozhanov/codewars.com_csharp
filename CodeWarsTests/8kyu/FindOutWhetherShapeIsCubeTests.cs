using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindOutWhetherShapeIsCubeTests
    {
        [Test]
        public void ShouldReturnFalse()
        {
            FindOutWhetherShapeIsCube cube = new FindOutWhetherShapeIsCube();
            Assert.AreEqual(true, cube.IsCube(1, 1));
            Assert.AreEqual(true, cube.IsCube(8, 2));
        }

        [Test]
        public void ShouldReturnTrue()
        {
            FindOutWhetherShapeIsCube cube = new FindOutWhetherShapeIsCube();
            Assert.AreEqual(false, cube.IsCube(2, 1));
            Assert.AreEqual(false, cube.IsCube(6, 3));
            Assert.AreEqual(false, cube.IsCube(-8, -2));
            Assert.AreEqual(false, cube.IsCube(0, 0));
            Assert.AreEqual(false, cube.IsCube(200, 4));
        }
    }
}