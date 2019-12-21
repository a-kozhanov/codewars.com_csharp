using System.Drawing;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GeometryBasicsCircleAreaIn2DTests
    {
        private static double epsilon = 1e-6;
  
        [Test]
        public void SampleTest()
        {
            Assert.That(GeometryBasicsCircleAreaIn2D.CircleArea
                (
                    new GeometryBasicsCircleAreaIn2D.Circle(new GeometryBasicsCircleAreaIn2D.Point(10, 10), 30)
                    ), 
                Is.EqualTo(2827.433388).Within(epsilon));
            
            Assert.That(GeometryBasicsCircleAreaIn2D.CircleArea(new GeometryBasicsCircleAreaIn2D.Circle(new GeometryBasicsCircleAreaIn2D.Point(25, -70), 30)), Is.EqualTo(2827.433388).Within(epsilon));
            Assert.That(GeometryBasicsCircleAreaIn2D.CircleArea(new GeometryBasicsCircleAreaIn2D.Circle(new GeometryBasicsCircleAreaIn2D.Point(-15, 5), 0)), Is.EqualTo(0).Within(epsilon));
            Assert.That(GeometryBasicsCircleAreaIn2D.CircleArea(new GeometryBasicsCircleAreaIn2D.Circle(new GeometryBasicsCircleAreaIn2D.Point(-15, 5), 12.5)), Is.EqualTo(490.873852).Within(epsilon));
        }  
    }
}