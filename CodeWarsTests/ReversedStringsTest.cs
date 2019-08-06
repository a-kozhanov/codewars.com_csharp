using System;
using System.Linq;
using NUnit.Framework;
using  CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReversedStringsTests
    {
        [Test]
        public void WorldTest()
        {
            Assert.AreEqual("dlrow", ReversedStrings.Solution("world"));
        }


        private static Random rnd = new Random();

        private static string solution(string str) => String.Concat(str.Reverse());

        private static string chars = "abcdefghijklmnopqrstuvwxyz    ,./';123456789!?";

        [Test]
        public void SubmitTests()
        {
            Assert.AreEqual("dlrow", ReversedStrings.Solution("world"));
            Assert.AreEqual("olleh", ReversedStrings.Solution("hello"));
            Assert.AreEqual("", ReversedStrings.Solution(""));
            Assert.AreEqual("h", ReversedStrings.Solution("h"));
            Assert.AreEqual("selur srawedoC", ReversedStrings.Solution("Codewars rules"));
        }

        [Test]
        public void RandomTests()
        {
            const int Tests = 100;

            for (int i = 0; i < Tests; ++i)
            {
                string str = String.Concat(new char[rnd.Next(1, 100)].Select(_ => chars[rnd.Next(0, chars.Length)]));

                string expected = solution(str);
                string actual = ReversedStrings.Solution(str);

                Assert.AreEqual(expected, actual);
            }
        }

    }
}