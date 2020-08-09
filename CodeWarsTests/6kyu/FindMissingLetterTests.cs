using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataFindMissingLetterTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual('e', KataFindMissingLetter.FindMissingLetter(new[] {'a', 'b', 'c', 'd', 'f'}));
            Assert.AreEqual('P', KataFindMissingLetter.FindMissingLetter(new[] {'O', 'Q', 'R', 'S'}));
        }
    }
}