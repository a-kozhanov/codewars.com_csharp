using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BattleOfCharactersMediumTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("Two", BattleOfCharactersMedium.Battle("One", "Two"));
            Assert.AreEqual("One", BattleOfCharactersMedium.Battle("One", "Neo"));
            Assert.AreEqual("Tie!", BattleOfCharactersMedium.Battle("One", "neO"));
            Assert.AreEqual("Tie!", BattleOfCharactersMedium.Battle("Foo", "BAR"));
            Assert.AreEqual("Four", BattleOfCharactersMedium.Battle("Four", "Five"));
        }
    }
}