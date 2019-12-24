using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NBAFull48MinutesAverageTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(28.8, NBAFull48MinutesAverage.NbaExtrap(12, 20));
            Assert.AreEqual(48.0, NBAFull48MinutesAverage.NbaExtrap(10, 10));
            Assert.AreEqual(14.1, NBAFull48MinutesAverage.NbaExtrap(5, 17));
            Assert.AreEqual(0, NBAFull48MinutesAverage.NbaExtrap(0, 0));
            Assert.AreEqual(42.6, NBAFull48MinutesAverage.NbaExtrap(30.8, 34.7));
            Assert.AreEqual(32.5, NBAFull48MinutesAverage.NbaExtrap(22.9, 33.8));
        }
    }
}