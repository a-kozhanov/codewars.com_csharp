using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BattleOfCharactersEasyTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Z", BattleOfCharactersEasy.Battle("AAA", "Z"));
            Assert.AreEqual("TWO", BattleOfCharactersEasy.Battle("ONE", "TWO"));
            Assert.AreEqual("Tie!", BattleOfCharactersEasy.Battle("ONE", "NEO"));
            Assert.AreEqual("FOUR", BattleOfCharactersEasy.Battle("FOUR", "FIVE"));
        }
    }
}