using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class PlayingWithCubesITests
    {
        [Test]
        public static void FixedTest()
        {
            Cube c = new Cube();
            Assert.AreEqual(0, c.GetSide(), "when not set before, Side should be 0");
            c.SetSide(5);
            Assert.AreEqual(5, c.GetSide(), "Should return 5");
        }
    }
}