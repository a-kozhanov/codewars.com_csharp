using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FeastOfManyBeastsTests
    {
        [TestCase("great blue heron", "garlic naan")]
        [TestCase("chickadee", "chocolate cake")]
        public void BasicTestsTrue(string beast, string dish)
        {
            Assert.IsTrue(FeastOfManyBeasts.Feast(beast, dish));
        }

        [TestCase("brown bear", "bear claw")]
        public void BasicTestsFalse(string beast, string dish)
        {
            Assert.IsFalse(FeastOfManyBeasts.Feast(beast, dish));
        }
    }
}