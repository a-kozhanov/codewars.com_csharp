using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MostValuableCharacterTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual('a', MostValuableCharacter.solve("a"));
            Assert.AreEqual('a', MostValuableCharacter.solve("aa"));
            Assert.AreEqual('b', MostValuableCharacter.solve("bcd"));
            Assert.AreEqual('x', MostValuableCharacter.solve("axyzxyz"));
            Assert.AreEqual('a', MostValuableCharacter.solve("dcbadcba"));
            Assert.AreEqual('c', MostValuableCharacter.solve("aabccc"));
            Assert.AreEqual('e', MostValuableCharacter.solve("efgefg"));
            Assert.AreEqual('e', MostValuableCharacter.solve("efghijefghi"));
            Assert.AreEqual('a', MostValuableCharacter.solve("acefacef"));
            Assert.AreEqual('a', MostValuableCharacter.solve("acefacefacef"));
        }
    }
}