using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TemperatureAnalysisITests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(-8, TemperatureAnalysisI.LowestTemperature("-1 50 -4 20 22 -7 0 10 -8"));
            Assert.AreEqual(10, TemperatureAnalysisI.LowestTemperature("10 50 12 20 22 13 20 100 18"));
            Assert.AreEqual(-1, TemperatureAnalysisI.LowestTemperature("-1 50 16 20 22 1 0 10 34"));
            Assert.AreEqual(-2, TemperatureAnalysisI.LowestTemperature("-2 3 -1 12 45 14"));
            Assert.AreEqual(null, TemperatureAnalysisI.LowestTemperature(""));
        }
    }
}