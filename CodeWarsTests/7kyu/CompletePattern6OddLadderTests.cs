using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CompletePattern6OddLadderTests
    {
        [Test]
        public void Test_3()
        {
            Assert.AreEqual("1\n333", CompletePattern6OddLadder.OddLadder(4), "Nope!");
        }
    }
}