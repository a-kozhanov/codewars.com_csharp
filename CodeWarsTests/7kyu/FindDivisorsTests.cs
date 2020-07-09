using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindDivisorsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] {3, 5}, FindDivisors.Divisors(15));
            Assert.AreEqual(new int[] {2, 4, 8}, FindDivisors.Divisors(16));
            Assert.AreEqual(new int[] {11, 23}, FindDivisors.Divisors(253));
            Assert.AreEqual(new int[] {2, 3, 4, 6, 8, 12}, FindDivisors.Divisors(24));
        }

        private static Random rnd = new Random();

        private static int[] solution(int n)
        {
            // 1 and 2 are prime
            if (n <= 2)
            {
                return null;
            }

            // Only need to check up until the square root of n
            double sqrt = Math.Sqrt(n);

            List<int> divisors = new List<int>();

            // Get first half of divisors
            for (double i = 2; i < sqrt; ++i)
            {
                // if n / i is integer
                if (n / i % 1 == 0)
                {
                    divisors.Add((int) i);
                }
            }

            // Concat flipped divisors onto our list
            divisors = divisors.Concat(
                // Reverse flipped divisors, (24) {2, 3, 4} => {12, 8, 6} => {6, 8, 12}
                Enumerable.Reverse(divisors.Select(v => n / v))
            ).ToList();

            // If n is a perfect square, insert sqrt into the middle of the list
            if (sqrt % 1 == 0)
            {
                divisors.Insert(divisors.Count / 2, (int) sqrt);
            }

            // If our list of divisors is still empty, return null as n is prime
            if (divisors.Count == 0)
            {
                return null;
            }

            return divisors.ToArray();
        }

        [Test, Description("Light Random Tests")]
        public void LightRandomTests()
        {
            for (int i = 0; i < 100; ++i)
            {
                int test = rnd.Next(2, 101);
                int[] expected = solution(test);
                int[] actual = FindDivisors.Divisors(test);
                Assert.AreEqual(expected, actual);
            }
        }

        [Test, Description("Performance Random Tests")]
        public void HeavyRandomTests()
        {
            for (int i = 0; i < 1000; ++i)
            {
                int test = int.MaxValue - rnd.Next(2, 100001);
                int[] expected = solution(test);
                int[] actual = FindDivisors.Divisors(test);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}