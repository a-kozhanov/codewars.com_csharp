using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CompletePattern5EvenLadderTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("22", CompletePattern5EvenLadder.Pattern(2));
            Assert.AreEqual("", CompletePattern5EvenLadder.Pattern(1));
            Assert.AreEqual("22\n4444", CompletePattern5EvenLadder.Pattern(5));
            Assert.AreEqual("", CompletePattern5EvenLadder.Pattern(0));
            Assert.AreEqual("", CompletePattern5EvenLadder.Pattern(-25));
        }
    }
}