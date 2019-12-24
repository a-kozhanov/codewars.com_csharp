using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GeometryBasicsDistanceBetweenPointsIn2DTests
    {
        private static double epsilon = 1e-6;
    
        [Test]
        public void SampleTest()
        {
            Assert.That(0, Is.EqualTo(GeometryBasicsDistanceBetweenPointsIn2D.DistanceBetweenPoints(new GeometryBasicsDistanceBetweenPointsIn2D.Point(3, 3), new GeometryBasicsDistanceBetweenPointsIn2D.Point(3, 3))).Within(epsilon));
            Assert.That(5, Is.EqualTo(GeometryBasicsDistanceBetweenPointsIn2D.DistanceBetweenPoints(new GeometryBasicsDistanceBetweenPointsIn2D.Point(1, 6), new GeometryBasicsDistanceBetweenPointsIn2D.Point(4, 2))).Within(epsilon));
            Assert.That(10.728001, Is.EqualTo(GeometryBasicsDistanceBetweenPointsIn2D.DistanceBetweenPoints(new GeometryBasicsDistanceBetweenPointsIn2D.Point(-10.2, 12.5), new GeometryBasicsDistanceBetweenPointsIn2D.Point(0.3, 14.7))).Within(epsilon));
        }       
    }
}