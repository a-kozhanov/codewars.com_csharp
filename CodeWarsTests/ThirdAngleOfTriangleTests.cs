using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThirdAngleOfTriangleTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(ThirdAngleOfTriangle.OtherAngle(30, 60), Is.EqualTo(90));
            Assert.That(ThirdAngleOfTriangle.OtherAngle(60, 60), Is.EqualTo(60));
            Assert.That(ThirdAngleOfTriangle.OtherAngle(43, 78), Is.EqualTo(59));
            Assert.That(ThirdAngleOfTriangle.OtherAngle(10, 20), Is.EqualTo(150));
        }
    }
}