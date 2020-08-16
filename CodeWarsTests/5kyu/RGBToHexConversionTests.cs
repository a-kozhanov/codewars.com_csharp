using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RGBToHexConversionTests
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual("FFFFFF", RGBToHexConversion.Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", RGBToHexConversion.Rgb(255, 255, 300));
            Assert.AreEqual("000000", RGBToHexConversion.Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", RGBToHexConversion.Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", RGBToHexConversion.Rgb(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", RGBToHexConversion.Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", RGBToHexConversion.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }
    }
}