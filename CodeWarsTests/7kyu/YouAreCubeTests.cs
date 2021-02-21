using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class YouAreCubeTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, YouAreCube.YouAreACube(27));
            Assert.AreEqual(true, YouAreCube.YouAreACube(1));
            Assert.AreEqual(false, YouAreCube.YouAreACube(2));
            Assert.AreEqual(false, YouAreCube.YouAreACube(99));
            Assert.AreEqual(true, YouAreCube.YouAreACube(64));
        }
    }
}