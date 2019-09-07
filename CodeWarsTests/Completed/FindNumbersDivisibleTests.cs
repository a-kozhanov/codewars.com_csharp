using System;
using System.Collections.Generic;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindNumbersDivisibleTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 2, ExpectedResult = new int[] { 2, 4, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 3, ExpectedResult = new int[] { 3, 6 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6 }, 4, ExpectedResult = new int[] { 0, 4 })]
        public static int[] FixedTest(int[] numbers, int divisor)
        {
            return FindNumbersDivisible.DivisibleBy(numbers, divisor);
        }

        private static Random rnd = new Random();

        [Test, Description("Random Tests")]
        public static void RandomTest()
        {
            const int Tests = 1000;

            for (int i = 0; i < Tests; ++i)
            {
                int divisor = rnd.Next(1, 11);
                int[] numbers = new int[rnd.Next(10, 101)].Select(_ => rnd.Next(1, 1001)).ToArray();

                int[] expected = Solution(numbers, divisor);
                int[] actual = FindNumbersDivisible.DivisibleBy(numbers, divisor);

                Assert.AreEqual(expected, actual);
            }
        }

        private static int[] Solution(int[] numbers, int divisor)
        {
            return new List<int>(numbers).Where(x => x % divisor == 0).ToArray();
        }
    }
}