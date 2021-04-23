using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Coding3minPlantingTreesTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(4, Coding3minPlantingTrees.SC(3, 3, 1));
            Assert.AreEqual(2, Coding3minPlantingTrees.SC(3, 3, 3));
            Assert.AreEqual(0, Coding3minPlantingTrees.SC(3, 3, 2));
            Assert.AreEqual(6, Coding3minPlantingTrees.SC(7, 7, 3));
            Assert.AreEqual(8, Coding3minPlantingTrees.SC(3, 3, 0));
            Assert.AreEqual(0, Coding3minPlantingTrees.SC(3, 3, 10));
            Assert.AreEqual(2, Coding3minPlantingTrees.SC(2, 2, 1));
            Assert.AreEqual(4, Coding3minPlantingTrees.SC(2, 2, 0));
            Assert.AreEqual(200, Coding3minPlantingTrees.SC(200, 2, 1));
            Assert.AreEqual(200, Coding3minPlantingTrees.SC(2, 200, 1));
        }
    }
}