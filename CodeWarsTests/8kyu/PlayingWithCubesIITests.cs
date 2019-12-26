using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PlayingWithCubesIITests
    {
        [Test]
        public static void TestConstructor()
        {
            PlayingWithCubesII c = new PlayingWithCubesII(10);
            Assert.AreEqual(10, c.GetSide(), "Should be 10");
        }
    }
}