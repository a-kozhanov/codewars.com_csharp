using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataDrawStairsTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("I", KataDrawStairs.DrawStairs(1));
            Assert.AreEqual("I\n I", KataDrawStairs.DrawStairs(2));
            Assert.AreEqual("I\n I\n  I", KataDrawStairs.DrawStairs(3));
            Assert.AreEqual("I\n I\n  I\n   I", KataDrawStairs.DrawStairs(4));
        }
    }
}