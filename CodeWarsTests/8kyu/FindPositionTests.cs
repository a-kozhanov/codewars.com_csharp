using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindPositionTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Position of alphabet: 1", FindPosition.Position('a'));
            Assert.AreEqual("Position of alphabet: 26", FindPosition.Position('z'));
            Assert.AreEqual("Position of alphabet: 5", FindPosition.Position('e'));
        }
    }
}