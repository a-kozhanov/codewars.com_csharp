using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkfulNumberDrillsBlueAndEedMarblesTests
    {
        private const double Delta = 0.0000001;

        [Test]
        public void MyTest()
        {
            Assert.AreEqual(ThinkfulNumberDrillsBlueAndEedMarbles.GuessBlue(5, 5, 2, 3), 0.6, Delta);
            Assert.AreEqual(ThinkfulNumberDrillsBlueAndEedMarbles.GuessBlue(5, 7, 4, 3), 0.2, Delta);
            Assert.AreEqual(ThinkfulNumberDrillsBlueAndEedMarbles.GuessBlue(12, 18, 4, 6), 0.4, Delta);
        }
    }
}