using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountNumberCubesTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(1, CountNumberCubes.CountSquares(0));
            Assert.AreEqual(152, CountNumberCubes.CountSquares(5));
            Assert.AreEqual(1538, CountNumberCubes.CountSquares(16));
            Assert.AreEqual(3176, CountNumberCubes.CountSquares(23));
        }
    }
}