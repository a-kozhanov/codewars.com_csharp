using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CalculateTwoPeoplesIndividualAgesTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new double[] {14, 10}, CalculateTwoPeoplesIndividualAges.GetAges(24, 4), "it returns {14, 10} when passed 24, 4");
            Assert.AreEqual(new double[] {38.5, 24.5}, CalculateTwoPeoplesIndividualAges.GetAges(63, 14),
                "it returns {38.5, 24.5} when passed 63, 14");
            Assert.AreEqual(null, CalculateTwoPeoplesIndividualAges.GetAges(63, -14), "it returns null when passed 63, -14");
        }
    }
}