using System;
using System.Collections.Generic;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOfArraySinglesTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(15, SumOfArraySingles.Repeats(new List<int> {4, 5, 7, 5, 4, 8}));
            Assert.AreEqual(19, SumOfArraySingles.Repeats(new List<int> {9, 10, 19, 13, 19, 13}));
            Assert.AreEqual(12, SumOfArraySingles.Repeats(new List<int> {16, 0, 11, 4, 8, 16, 0, 11}));
            Assert.AreEqual(22, SumOfArraySingles.Repeats(new List<int> {5, 17, 18, 11, 13, 18, 11, 13}));
            Assert.AreEqual(24, SumOfArraySingles.Repeats(new List<int> {5, 10, 19, 13, 10, 13}));

            //Assert.AreEqual(13, SumOfArraySingles.Repeats(new List<int> {7, 9, 9, 9, 9, 9, 9, 6}));
        }

        [Test]
        public void RandomTest()
        {
            Random rnd = new Random();

            for (int i = 0; i < 100; ++i)
            {
                // Init List
                List<int> source = new List<int>();
                for (int j = 0; j < 100; ++j)
                {
                    source.Add(rnd.Next(0, 1000));
                }

                source = source.Distinct().ToList();

                // Unique check
                while (source.Count <= 4)
                {
                    source = source.Concat(source.Select(x => x + 1000)).Distinct().ToList();
                }

                // Dup every number but last two
                source = source.Concat(source.Take(source.Count - 2)).ToList();

                // Shuffle list (Fisher-Yates Shuffle)
                int n = source.Count;
                for (int j = 0; j < n; j++)
                {
                    int r = j + rnd.Next(n - j);
                    int t = source[r];
                    source[r] = source[j];
                    source[j] = t;
                }

                Assert.AreEqual(SolutionRepeats(source), SumOfArraySingles.Repeats(source));
            }
        }

        public static int SolutionRepeats(List<int> source)
        {
            var seen = new HashSet<int>();
            int sum = 0;

            foreach (int item in source)
            {
                if (!seen.Contains(item))
                {
                    seen.Add(item);
                    sum += item;
                }
                else
                {
                    sum -= item;
                }
            }

            return sum;
        }
    }
}