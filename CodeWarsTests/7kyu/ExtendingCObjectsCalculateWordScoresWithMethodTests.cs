using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExtendingCObjectsCalculateWordScoresWithMethodTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(6, "ABC".Score());
            Assert.AreEqual(96, "Knowledge".Score());
            Assert.AreEqual(98, "Hard Work".Score());
            Assert.AreEqual(0, ".,<>?".Score());
            Assert.AreEqual(0, "".Score());
        }
    }
}