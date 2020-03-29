using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PredictYourAgeTests
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(86, PredictYourAge.PredictAge(65, 60, 75, 55, 60, 63, 64, 45));
            Assert.AreEqual(79, PredictYourAge.PredictAge(32, 54, 76, 65, 34, 63, 64, 45));
        }
    }
}