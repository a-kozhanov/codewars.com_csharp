using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HeadsAndLegsTests
    {
        [Test]
        public void ValidNumberTests()
        {
            Assert.AreEqual(new int[] { 44, 28 }, HeadsAndLegs.Animals(72, 200));
            Assert.AreEqual(new int[] { 91, 25 }, HeadsAndLegs.Animals(116, 282));
            Assert.AreEqual(new int[] { 12, 0 }, HeadsAndLegs.Animals(12, 24));
            Assert.AreEqual(new int[] { 0, 6 }, HeadsAndLegs.Animals(6, 24));
            Assert.AreEqual(new int[] { 252, 92 }, HeadsAndLegs.Animals(344, 872));
            Assert.AreEqual(new int[] { 8, 150 }, HeadsAndLegs.Animals(158, 616));
        }

        [Test]
        public void InvalidNumberTests()
        {
            Assert.AreEqual("No solutions", HeadsAndLegs.Animals(25, 255));
            Assert.AreEqual("No solutions", HeadsAndLegs.Animals(12, 25));
            Assert.AreEqual("No solutions", HeadsAndLegs.Animals(54, 956));
            Assert.AreEqual("No solutions", HeadsAndLegs.Animals(5455, 54956));
        }

        [Test]
        public void EdgeCasesTests()
        {
            Assert.AreEqual(new int[] { 0, 0 }, HeadsAndLegs.Animals(0, 0));
            Assert.AreEqual("No solutions", HeadsAndLegs.Animals(-1, -1));
            Assert.AreEqual("No solutions", HeadsAndLegs.Animals(-45, 5));
            Assert.AreEqual("No solutions", HeadsAndLegs.Animals(500, 0));
            Assert.AreEqual("No solutions", HeadsAndLegs.Animals(0, 500));
            Assert.AreEqual("No solutions", HeadsAndLegs.Animals(5, -55));
        }
    }
}