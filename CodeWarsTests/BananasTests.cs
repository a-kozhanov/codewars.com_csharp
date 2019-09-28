using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    public class BananasTests
    {
        // common test code
        private void DoTest(string input, HashSet<string> expected, HashSet<string> actual)
        {
            Console.WriteLine($"INPUT: {input}");
            Console.WriteLine($"EXPECTED: {string.Join(", ", expected)} ");
            Assert.AreEqual(expected.Count, actual.Count, "wrong number of bananas!");
            Assert.IsTrue(actual.SetEquals(expected), $"ACTUAL: {string.Join(", ", actual)}\n  banana mismatch!");
        }

        [Test]
        public void Ex0()
        {
            var input = "banann";
            var expected = new HashSet<string>();
            var actual = KataBananas.Bananas(input);
            DoTest(input, expected, actual);
        }

        [Test]
        public void Ex1()
        {
            var input = "banana";
            var expected = new HashSet<string> { "banana" };
            var actual = KataBananas.Bananas(input);
            DoTest(input, expected, actual);
        }

        [Test]
        public void Ex2()
        {
            var input = "bbananana";
            var expected = new HashSet<string>
            {
                "b-an--ana", "-banana--", "-b--anana", "b-a--nana", "-banan--a",
                "b-ana--na", "b---anana", "-bana--na", "-ba--nana", "b-anan--a",
                "-ban--ana", "b-anana--"
            };
            var actual = KataBananas.Bananas(input);
            DoTest(input, expected, actual);
        }

        [Test]
        public void Ex3()
        {
            var input = "bananaaa";
            var expected = new HashSet<string> { "banan-a-", "banana--", "banan--a" };
            var actual = KataBananas.Bananas(input);
            DoTest(input, expected, actual);
        }

        [Test]
        public void Ex4()
        {
            var input = "bananana";
            var expected = new HashSet<string> { "ban--ana", "ba--nana", "bana--na", "b--anana", "banana--", "banan--a" };
            var actual = KataBananas.Bananas(input);
            DoTest(input, expected, actual);
        }
    }
}