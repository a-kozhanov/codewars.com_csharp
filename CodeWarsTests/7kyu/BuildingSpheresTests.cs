using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BuildingSpheresTests
    {
        [Test]
        public static void ExampleTest()
        {
            BuildingSpheres ball = new BuildingSpheres(2, 50);
            Assert.AreEqual(2, ball.GetRadius(), "Check radius");
            Assert.AreEqual(50, ball.GetMass(), "Check mass");
            Assert.AreEqual(33.51032, ball.GetVolume(), "Check volume");
            Assert.AreEqual(50.26548, ball.GetSurfaceArea(), "Check area");
            Assert.AreEqual(1.49208, ball.GetDensity(), "Check density");
        }
    }
}