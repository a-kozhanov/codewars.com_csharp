using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MexicanWaveTests
    {
        [TestCase]
        public void BasicTest1()
        {
            MexicanWave mexicanWave = new MexicanWave();
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.AreEqual(result, mexicanWave.wave("hello"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest2()
        {
            MexicanWave mexicanWave = new MexicanWave();
            List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
            Assert.AreEqual(result, mexicanWave.wave("codewars"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest3()
        {
            MexicanWave mexicanWave = new MexicanWave();
            List<string> result = new List<string> { };
            Assert.AreEqual(result, mexicanWave.wave(""), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest4()
        {
            MexicanWave mexicanWave = new MexicanWave();
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.AreEqual(result, mexicanWave.wave("two words"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest5()
        {
            MexicanWave mexicanWave = new MexicanWave();
            List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
            Assert.AreEqual(result, mexicanWave.wave(" gap "), "it should return '" + result + "'");
        }

    }
}