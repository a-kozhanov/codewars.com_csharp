using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RegexpBasicsIsItVowelTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(false, "".Vowel());
            Assert.AreEqual(true, "a".Vowel());
            Assert.AreEqual(true, "E".Vowel());
            Assert.AreEqual(false, "ou".Vowel());
            Assert.AreEqual(false, "z".Vowel());
            Assert.AreEqual(false, "lol".Vowel());
        }

        [Test]
        public void MoreTests()
        {
            Assert.AreEqual(false, " ".Vowel());
            Assert.AreEqual(false, "!".Vowel());
            Assert.AreEqual(false, "'".Vowel());
            Assert.AreEqual(false, "#".Vowel());
            Assert.AreEqual(false, "$".Vowel());
            Assert.AreEqual(false, "%".Vowel());
            Assert.AreEqual(false, "&".Vowel());
            Assert.AreEqual(false, "\"".Vowel());
            Assert.AreEqual(false, "(".Vowel());
            Assert.AreEqual(false, ")".Vowel());
            Assert.AreEqual(false, "*".Vowel());
            Assert.AreEqual(false, "+".Vowel());
            Assert.AreEqual(false, ",".Vowel());
            Assert.AreEqual(false, "-".Vowel());
            Assert.AreEqual(false, ".".Vowel());
            Assert.AreEqual(false, "/".Vowel());
            Assert.AreEqual(false, "0".Vowel());
            Assert.AreEqual(false, "1".Vowel());
            Assert.AreEqual(false, "2".Vowel());
            Assert.AreEqual(false, "3".Vowel());
            Assert.AreEqual(false, "4".Vowel());
            Assert.AreEqual(false, "5".Vowel());
            Assert.AreEqual(false, "6".Vowel());
            Assert.AreEqual(false, "7".Vowel());
            Assert.AreEqual(false, "8".Vowel());
            Assert.AreEqual(false, "9".Vowel());
            Assert.AreEqual(false, ":".Vowel());
            Assert.AreEqual(false, ";".Vowel());
            Assert.AreEqual(false, "<".Vowel());
            Assert.AreEqual(false, "=".Vowel());
            Assert.AreEqual(false, ">".Vowel());
            Assert.AreEqual(false, "?".Vowel());
            Assert.AreEqual(false, "@".Vowel());
            Assert.AreEqual(true, "A".Vowel());
            Assert.AreEqual(false, "B".Vowel());
            Assert.AreEqual(false, "C".Vowel());
            Assert.AreEqual(false, "D".Vowel());
            Assert.AreEqual(true, "E".Vowel());
            Assert.AreEqual(false, "F".Vowel());
            Assert.AreEqual(false, "G".Vowel());
            Assert.AreEqual(false, "H".Vowel());
            Assert.AreEqual(true, "I".Vowel());
            Assert.AreEqual(false, "J".Vowel());
            Assert.AreEqual(false, "K".Vowel());
            Assert.AreEqual(false, "L".Vowel());
            Assert.AreEqual(false, "M".Vowel());
            Assert.AreEqual(false, "N".Vowel());
            Assert.AreEqual(true, "O".Vowel());
            Assert.AreEqual(false, "P".Vowel());
            Assert.AreEqual(false, "Q".Vowel());
            Assert.AreEqual(false, "R".Vowel());
            Assert.AreEqual(false, "S".Vowel());
            Assert.AreEqual(false, "T".Vowel());
            Assert.AreEqual(true, "U".Vowel());
            Assert.AreEqual(false, "V".Vowel());
            Assert.AreEqual(false, "W".Vowel());
            Assert.AreEqual(false, "X".Vowel());
            Assert.AreEqual(false, "Y".Vowel());
            Assert.AreEqual(false, "Z".Vowel());
            Assert.AreEqual(false, "[".Vowel());
            Assert.AreEqual(false, "\\".Vowel());
            Assert.AreEqual(false, "]".Vowel());
            Assert.AreEqual(false, "^".Vowel());
            Assert.AreEqual(false, "_".Vowel());
            Assert.AreEqual(false, "`".Vowel());
            Assert.AreEqual(true, "a".Vowel());
            Assert.AreEqual(false, "b".Vowel());
            Assert.AreEqual(false, "c".Vowel());
            Assert.AreEqual(false, "d".Vowel());
            Assert.AreEqual(true, "e".Vowel());
            Assert.AreEqual(false, "f".Vowel());
            Assert.AreEqual(false, "g".Vowel());
            Assert.AreEqual(false, "h".Vowel());
            Assert.AreEqual(true, "i".Vowel());
            Assert.AreEqual(false, "j".Vowel());
            Assert.AreEqual(false, "k".Vowel());
            Assert.AreEqual(false, "l".Vowel());
            Assert.AreEqual(false, "m".Vowel());
            Assert.AreEqual(false, "n".Vowel());
            Assert.AreEqual(true, "o".Vowel());
            Assert.AreEqual(false, "p".Vowel());
            Assert.AreEqual(false, "q".Vowel());
            Assert.AreEqual(false, "r".Vowel());
            Assert.AreEqual(false, "s".Vowel());
            Assert.AreEqual(false, "t".Vowel());
            Assert.AreEqual(true, "u".Vowel());
            Assert.AreEqual(false, "v".Vowel());
            Assert.AreEqual(false, "w".Vowel());
            Assert.AreEqual(false, "x".Vowel());
            Assert.AreEqual(false, "y".Vowel());
            Assert.AreEqual(false, "z".Vowel());
            Assert.AreEqual(false, "{".Vowel());
            Assert.AreEqual(false, "|".Vowel());
            Assert.AreEqual(false, "}".Vowel());
            Assert.AreEqual(false, "~".Vowel());

            Assert.AreEqual(false, "a\na".Vowel());
            Assert.AreEqual(false, "a\nb".Vowel());
            Assert.AreEqual(false, "a\n".Vowel());
            Assert.AreEqual(false, " a".Vowel());
            Assert.AreEqual(false, "a ".Vowel());
        }
    }
}