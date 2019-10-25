using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AgeRangeCompatibilityEquationTests
    {
        [Test, Description("Example Test Cases")]
        public void Test()
        {
            Assert.AreEqual("15-20", AgeRangeCompatibilityEquation.DatingRange(17));
            Assert.AreEqual("27-66", AgeRangeCompatibilityEquation.DatingRange(40));
            Assert.AreEqual("14-16", AgeRangeCompatibilityEquation.DatingRange(15));
            Assert.AreEqual("24-56", AgeRangeCompatibilityEquation.DatingRange(35));
            Assert.AreEqual("9-11", AgeRangeCompatibilityEquation.DatingRange(10));
        }
    }
}