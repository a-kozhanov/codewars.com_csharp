using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    class RemoveFirstLastCharacterTests
    {
        [Test]
        public void Test1()
        {
            StringAssert.AreEqualIgnoringCase("loquen", RemoveFirstLastCharacter.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", RemoveFirstLastCharacter.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", RemoveFirstLastCharacter.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", RemoveFirstLastCharacter.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", RemoveFirstLastCharacter.Remove_char("ok"));
        }
    }
}