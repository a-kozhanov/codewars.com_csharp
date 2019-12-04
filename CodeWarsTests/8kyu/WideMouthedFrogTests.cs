using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WideMouthedFrogTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("wide", WideMouthedFrog.MouthSize("toucan"));
            Assert.AreEqual("wide", WideMouthedFrog.MouthSize("ant bear"));
            Assert.AreEqual("small", WideMouthedFrog.MouthSize("alligator"));
        }
    }
}