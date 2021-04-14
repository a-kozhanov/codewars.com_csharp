using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ApproachingEnemiesTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(45, ApproachingEnemies.CalculateTime(new double[2] {100, 100}, new double[2] {90, 90}));
            Assert.AreEqual(40, ApproachingEnemies.CalculateTime(new double[2] {-90, 0}, new double[2] {-80, 0}));
            Assert.AreEqual(95, ApproachingEnemies.CalculateTime(new double[2] {50, -100}, new double[2] {47.5, -95}));
        }
    }
}