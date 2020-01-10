using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BreakingChocolateProblemTests
    {
        [Test]
        public void SimpleTests()
        {
            Assert.AreEqual(24, BreakingChocolateProblem.BreakChocolate(5, 5));
            Assert.AreEqual(0, BreakingChocolateProblem.BreakChocolate(1, 1));
        }
    }
}