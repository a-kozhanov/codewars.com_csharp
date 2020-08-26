using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConsonantValueTests
    {
        [TestCase("zodiac", 26)]
        [TestCase("chruschtschov", 80)]
        [TestCase("khrushchev", 38)]
        [TestCase("strength", 57)]
        [TestCase("catchphrase", 73)]
        [TestCase("twelfthstreet", 103)]
        [TestCase("mischtschenkoana", 80)]
        public void BasicTests(string input, int expected)
        {
            Assert.That(ConsonantValue.Solve(input), Is.EqualTo(expected));
        }

        // [Test]
        // public void RandomTests()
        // {
        //     for (int i = 0; i < 100; i++)
        //     {
        //         var s = RandomWord();
        //         var ex = SolutionSolver(s);
        //         Assert.That(ConsonantValue.Solve(s), Is.EqualTo(ex));
        //     }
        // }

        private string RandomWord()
        {
            var rnd = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, rnd.Next(1, 50))
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        private static int SolutionSolver(string s)
        {
            var split = s.ToLower().Split(new[] {'a', 'e', 'i', 'o', 'u'}, StringSplitOptions.RemoveEmptyEntries);
            return split.Select(w => w.Sum(x => x - 96)).Max();
        }
    }
}