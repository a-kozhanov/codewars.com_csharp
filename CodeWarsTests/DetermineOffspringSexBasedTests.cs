using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DetermineOffspringSexBasedTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Congratulations! You're going to have a son.", DetermineOffspringSexBased.ChromosomeCheck("XY"));
            Assert.AreEqual("Congratulations! You're going to have a daughter.", DetermineOffspringSexBased.ChromosomeCheck("XX"));
        }
    }
}