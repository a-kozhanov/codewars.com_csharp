using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NoobCode03CheckTheseLettersTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, NoobCode03CheckTheseLetters.LetterCheck(new string[] {"trances", "nectar"}));
            Assert.AreEqual(true, NoobCode03CheckTheseLetters.LetterCheck(new string[] {"THE EYES", "they see"}));
            Assert.AreEqual(false, NoobCode03CheckTheseLetters.LetterCheck(new string[] {"assert", "staring"}));
            Assert.AreEqual(false, NoobCode03CheckTheseLetters.LetterCheck(new string[] {"arches", "later"}));
            Assert.AreEqual(false, NoobCode03CheckTheseLetters.LetterCheck(new string[] {"dale", "caller"}));
            Assert.AreEqual(false, NoobCode03CheckTheseLetters.LetterCheck(new string[] {"parses", "parsecs"}));
            Assert.AreEqual(false, NoobCode03CheckTheseLetters.LetterCheck(new string[] {"replays", "adam"}));
            Assert.AreEqual(true, NoobCode03CheckTheseLetters.LetterCheck(new string[] {"mastering", "streaming"}));
            Assert.AreEqual(false, NoobCode03CheckTheseLetters.LetterCheck(new string[] {"drapes", "compadres"}));
            Assert.AreEqual(true, NoobCode03CheckTheseLetters.LetterCheck(new string[] {"deltas", "slated"}));
        }
    }
}