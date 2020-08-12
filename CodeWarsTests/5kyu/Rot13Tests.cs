using System;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataRot13Tests
    {
        [Test, Description("test")]
        public void testTest()
        {
            Assert.AreEqual("grfg", KataRot13.Rot13("test"),
                String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", KataRot13.Rot13("test")));
        }

        [Test, Description("Test")]
        public void TestTest()
        {
            Assert.AreEqual("Grfg", KataRot13.Rot13("Test"),
                String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", KataRot13.Rot13("Test")));
        }

        [Test, Description("Codewars")]
        public void CodewarsTest()
        {
            Assert.AreEqual("Pbqrjnef", KataRot13.Rot13("Codewars"),
                String.Format("Input: Codewars, Expected Output: Pbqrjnef, Actual Output: {0}",
                    KataRot13.Rot13("Codewars")));
        }

        [Test, Description("C# is cool!")]
        public void CSTest()
        {
            Assert.AreEqual("P# vf pbby!", KataRot13.Rot13("C# is cool!"),
                String.Format("Input: C# is cool!, Expected Output: P# vf pbby!, Actual Output: {0}",
                    KataRot13.Rot13("C# is cool!")));
        }

        [Test, Description("10+2 is twelve.")]
        public void ArithTest()
        {
            Assert.AreEqual("10+2 vf gjryir.", KataRot13.Rot13("10+2 is twelve."),
                String.Format("Input: Codewars, Expected Output: 10+2 vf gjryir., Actual Output: {0}",
                    KataRot13.Rot13("10+2 is twelve.")));
        }

        [Test, Description("abcdefghijklmnopqrstuvwxyz")]
        public void AlphabetTest()
        {
            Assert.AreEqual("nopqrstuvwxyzabcdefghijklm", KataRot13.Rot13("abcdefghijklmnopqrstuvwxyz"),
                String.Format(
                    "Input: abcdefghijklmnopqrstuvwxyz, Expected Output: nopqrstuvwxyzabcdefghijklm, Actual Output: {0}",
                    KataRot13.Rot13("abcdefghijklmnopqrstuvwxyz")));
        }

        private static Random rnd = new Random();

        private static string solution(string message)
        {
            // Pattern which matches any letter, ignoring case
            Regex pattern = new Regex("([a-z])", RegexOptions.IgnoreCase);

            // Function which will evaulate a Regex match and return a new string
            // In this case shifting the letter by 13 (fake mod 26)
            Func<Match, string> shifter = (letter) =>
                ((char) (letter.Value[0] + ((Char.ToLower(letter.Value[0]) >= 'n') ? -13 : 13))).ToString();

            // Return the modified string
            return pattern.Replace(message, new MatchEvaluator(shifter));
        }

        [Test, Description("Random Strings")]
        public void RandomTest()
        {
            const int Tests = 100;

            for (int i = 0; i < Tests; ++i)
            {
                string test = String.Concat(new char[50].Select(_ =>
                    (rnd.Next(0, 6) == 0) ? (char) rnd.Next(32, 127) :
                    (rnd.Next(0, 2) == 0) ? (char) rnd.Next(65, 91) : (char) rnd.Next(97, 123)));
                string actual = KataRot13.Rot13(test);
                string expected = solution(test);

                Assert.AreEqual(expected, actual,
                    String.Format("Input: {0}, Expected Output: {1}, Actual Output: {2}", test, expected, actual));
            }
        }
    }
}