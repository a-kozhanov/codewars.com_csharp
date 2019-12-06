using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TipCalculatorTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(4, TipCalculator.CalculateTip(20, "Excellent"));
            Assert.AreEqual(3, TipCalculator.CalculateTip(26.95, "good"));
        }
    }
}