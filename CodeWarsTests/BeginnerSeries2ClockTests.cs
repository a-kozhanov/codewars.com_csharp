using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BeginnerSeries2ClockTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(61000, BeginnerSeries2Clock.Past(0, 1, 1));
        }
    }
}