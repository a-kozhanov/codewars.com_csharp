using System;
using System.Collections.Generic;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TitleCaseTests
    {
        [TestCase("aBC deF Ghi", null, "Abc Def Ghi")]
        [TestCase("ab", "ab", "Ab")]
        [TestCase("a bc", "bc", "A bc")]
        [TestCase("a bc", "BC", "A bc")]
        [TestCase("First a of in", "an often into", "First A Of In")]
        [TestCase("a clash of KINGS", "a an the OF", "A Clash of Kings")]
        [TestCase("the QUICK bRoWn fOX", "xyz fox quick the", "The quick Brown fox")]
        public void MyTest(string sampleTitle, string sampleMinorWords, string expected)
        {
            Assert.AreEqual(expected, TitleCase.titleCase(sampleTitle, sampleMinorWords));
        }

        [Test]
        public void MyTest2()
        {
            Assert.AreEqual("", TitleCase.titleCase(""));
        }

        [Test]
        public void MyTest3()
        {
            Assert.AreEqual("The Quick Brown Fox", TitleCase.titleCase("the quick brown fox"));
        }

        private static Random rnd = new Random();

        public static string TitleCaseTrue(string title, string minorWords = "")
        {
            if (string.IsNullOrEmpty(title)) return "";

            string[] words = title.ToLower().Split(' ');
            string[] ex = (minorWords == null) ? new string[1] : minorWords.ToLower().Split(' ');

            var result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0 || !ex.Contains(words[i]))
                    result.Add(ProperCase(words[i]));
                else
                    result.Add(words[i]);
            }

            return string.Join(" ", result);
        }

        private static string ProperCase(string text)
        {
            return text[0].ToString().ToUpper() + text.Substring(1, text.Length - 1);
        }

        private static string chars = "                      abcdefghjiklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        [Test, Description("Random Tests")]
        public void RandomTest()
        {
            const int Tests = 100;

            for (int i = 0; i < Tests; ++i)
            {
                string test = String.Join(" ",
                    String.Concat(new String('.', rnd.Next(40, 201)).Select(_ => chars[rnd.Next(0, chars.Length)]))
                        .Split(' ').Where(s => !String.IsNullOrEmpty(s))).Trim();
                string[] words = test.Split(' ');
                string minorWords = String.Join(" ",
                    new string[]
                    {
                        words[rnd.Next(0, words.Length)], words[rnd.Next(0, words.Length)],
                        words[rnd.Next(0, words.Length)], words[rnd.Next(0, words.Length)]
                    }.Distinct());

                string expected = TitleCaseTrue(test, minorWords);
                string actual = TitleCase.titleCase(test, minorWords);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}