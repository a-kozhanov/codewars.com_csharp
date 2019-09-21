using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SurfaceAreaVolumeBoxTests
    {
        [Test]
        public void Test1()
        {
            //Assert.AreEqual(new[] { 88, 48 }, SurfaceAreaVolumeBox.Get_size(4, 2, 6));
            Assert.AreEqual(new[] { 6, 1 }, SurfaceAreaVolumeBox.Get_size(1, 1, 1));
            Assert.AreEqual(new[] { 10, 2 }, SurfaceAreaVolumeBox.Get_size(1, 2, 1));
            Assert.AreEqual(new[] { 16, 4 }, SurfaceAreaVolumeBox.Get_size(1, 2, 2));
            Assert.AreEqual(new[] { 600, 1000 }, SurfaceAreaVolumeBox.Get_size(10, 10, 10));
        }
    }
}