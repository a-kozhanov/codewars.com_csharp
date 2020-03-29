using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsItNegativeZeroTests
    {
        [Test, Description("should return true for -0")]
        public void Test1()
        {
            Assert.AreEqual(true, IsItNegativeZero.IsNegativeZero(-0.0));
        }

        [Test, Description("should return false for non-negative-zero numbers")]
        public void Test2()
        {
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(double.NegativeInfinity));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(-5.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(-4.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(-3.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(-2.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(-1.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(-double.MaxValue));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(0.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(-double.MinValue));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(1.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(2.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(3.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(4.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(5.0));
            Assert.AreEqual(false, IsItNegativeZero.IsNegativeZero(double.PositiveInfinity));
        }
    }
}