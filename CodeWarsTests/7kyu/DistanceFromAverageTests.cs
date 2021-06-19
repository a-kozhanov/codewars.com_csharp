using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public class DistanceFromAverageTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new[] {4.2, -35.8, -2.8, 23.2, 11.2},
                DistanceFromAverage.DistancesFromAverage(new[] {55, 95, 62, 36, 48}));
            Assert.AreEqual(new[] {0, 0, 0, 0, 0}, DistanceFromAverage.DistancesFromAverage(new[] {1, 1, 1, 1, 1}));
            Assert.AreEqual(new[] {-1.0, 1.0, -1.0, 1.0, -1.0, 1.0},
                DistanceFromAverage.DistancesFromAverage(new[] {1, -1, 1, -1, 1, -1}));
            Assert.AreEqual(new[] {-0.8, 1.2, -0.8, 1.2, -0.8},
                DistanceFromAverage.DistancesFromAverage(new[] {1, -1, 1, -1, 1}));
            Assert.AreEqual(new[] {-2.0, 2.0}, DistanceFromAverage.DistancesFromAverage(new[] {2, -2}));
            Assert.AreEqual(new[] {0}, DistanceFromAverage.DistancesFromAverage(new[] {1}));
            Assert.AreEqual(new[] {6197.6, 6385.6, -26111.4, 6673.6, 6854.6},
                DistanceFromAverage.DistancesFromAverage(new[] {123, -65, 32432, -353, -534}));
        }
    }
}