using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    public class AlphabeticalAdditionTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual('f', AlphabeticalAddition.AddLetters(new char[] {'a', 'b', 'c'}));
            Assert.AreEqual('z', AlphabeticalAddition.AddLetters(new char[] {'z'}));
            Assert.AreEqual('c', AlphabeticalAddition.AddLetters(new char[] {'a', 'b'}));
            Assert.AreEqual('c', AlphabeticalAddition.AddLetters(new char[] {'c'}));
            Assert.AreEqual('a', AlphabeticalAddition.AddLetters(new char[] {'z', 'a'}));
            Assert.AreEqual('d', AlphabeticalAddition.AddLetters(new char[] {'y', 'c', 'b'}));
            Assert.AreEqual('z', AlphabeticalAddition.AddLetters(new char[] { }));
        }
    }
}