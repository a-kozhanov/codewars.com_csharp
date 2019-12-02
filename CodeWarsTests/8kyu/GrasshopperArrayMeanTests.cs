using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperArrayMeanTests
    {
        [Test]
        public void FirstTest()
        {
            Assert.AreEqual(1, GrasshopperArrayMean.FindAverage(new[] { 1 }));
        }

        [Test]
        public void SecondTest()
        {
            Assert.AreEqual(4, GrasshopperArrayMean.FindAverage(new[] { 1, 3, 5, 7 }));
        }

        [Test]
        public void ThirdTest()
        {
            Assert.AreEqual(-5, GrasshopperArrayMean.FindAverage(new[] { -10, -5, -5, 0 }));
        }

        [Test]
        public void FourthTest()
        {
            Assert.AreEqual(0, GrasshopperArrayMean.FindAverage(new[] { 0 }));
        }
    }
}