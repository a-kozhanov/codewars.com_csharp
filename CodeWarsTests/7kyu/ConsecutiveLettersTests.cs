using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConsecutiveLettersTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, ConsecutiveLetters.solve("abc"));
            Assert.AreEqual(false, ConsecutiveLetters.solve("abd"));
            Assert.AreEqual(true, ConsecutiveLetters.solve("dabc"));
            Assert.AreEqual(false, ConsecutiveLetters.solve("abbc"));
            Assert.AreEqual(false, ConsecutiveLetters.solve("adda"));
        }
    }
}