using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OrderedCountOfCharactersTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(
                new List<Tuple<char, int>>()
                {
                    tuple('a', 5),
                    tuple('b', 2),
                    tuple('r', 2),
                    tuple('c', 1),
                    tuple('d', 1)
                },
                OrderedCountOfCharacters.OrderedCount("abracadabra")
            );
            Assert.AreEqual(
                new List<Tuple<char, int>>()
                {
                    tuple('C', 1),
                    tuple('o', 1),
                    tuple('d', 1),
                    tuple('e', 1),
                    tuple(' ', 1),
                    tuple('W', 1),
                    tuple('a', 1),
                    tuple('r', 1),
                    tuple('s', 1)
                },
                OrderedCountOfCharacters.OrderedCount("Code Wars")
            );
        }

        private static Tuple<char, int> tuple(char character, int count)
        {
            return new Tuple<char, int>(character, count);
        }
    }
}