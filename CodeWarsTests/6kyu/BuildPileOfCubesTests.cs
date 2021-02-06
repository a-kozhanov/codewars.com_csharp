using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BuildPileOfCubesTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(2022, BuildPileOfCubes.findNb(4183059834009));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(-1, BuildPileOfCubes.findNb(24723578342962));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(4824, BuildPileOfCubes.findNb(135440716410000));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(3568, BuildPileOfCubes.findNb(40539911473216));
        }
    }
}