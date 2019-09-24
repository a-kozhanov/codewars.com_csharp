using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    class CorrectMistakesCharacterTests
    {
        [Test]
        public void CorrectTests()
        {
            Assert.AreEqual("LONDON", CorrectMistakesCharacter.Correct("L0ND0N"));
            Assert.AreEqual("DUBLIN", CorrectMistakesCharacter.Correct("DUBL1N"));
            Assert.AreEqual("SINGAPORE", CorrectMistakesCharacter.Correct("51NGAP0RE"));
            Assert.AreEqual("BUDAPEST", CorrectMistakesCharacter.Correct("BUDAPE5T"));
            Assert.AreEqual("PARIS", CorrectMistakesCharacter.Correct("PAR15"));
        }
    }
}
