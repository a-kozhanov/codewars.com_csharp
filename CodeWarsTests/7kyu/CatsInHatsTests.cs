using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CatsInHatsTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("3331148.800", CatsInHats.Height(7));
            Assert.AreEqual("2000000.000", CatsInHats.Height(0));
        }
    }
}