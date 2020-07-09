using System;
using System.Diagnostics;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindCountOfMostFrequentItemInAnArrayTests
    {
        private static Random rnd = new Random();

        private static int solution(int[] collection)
        {
            if (collection.Length == 0)
            {
                return 0;
            }

            return collection
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .First().Count();
        }

        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] {new int[] {3, -1, -1}, 2},
            new object[] {new int[] {3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3}, 5},
        };

        private static object[] Edge_Test_Cases = new object[]
        {
            new object[] {new int[] { }, 0},
            new object[] {new int[] {9}, 1},
        };

        // [Test, TestCaseSource(typeof(FindCountOfMostFrequentItemInAnArrayTests), "Basic_Test_Cases")]
        // public void Basic_Test(int[] test, int expected)
        // {
        //     Assert.AreEqual(expected, FindCountOfMostFrequentItemInAnArray.MostFrequentItemCount(test));
        // }

        [Test, TestCaseSource(typeof(FindCountOfMostFrequentItemInAnArrayTests), "Edge_Test_Cases")]
        public void Edge_Test(int[] test, int expected)
        {
            Assert.AreEqual(expected, FindCountOfMostFrequentItemInAnArray.MostFrequentItemCount(test));
        }

        [Test, Description("Random Tests (1000 assertions)")]
        public void Random_Test()
        {
            Stopwatch sw = new Stopwatch();
            const int tests = 1000;

            for (int i = 0; i < tests; ++i)
            {
                int[] test = new int[rnd.Next(0, 100)];

                for (int j = 0; j < test.Length; ++j)
                {
                    test[j] = rnd.Next(-15, 16);
                }

                int[] clone = (int[]) test.Clone();

                sw.Start();
                int actual = FindCountOfMostFrequentItemInAnArray.MostFrequentItemCount(test);
                sw.Stop();

                Assert.AreEqual(test, clone, "User mutated the input array!");
                int expected = solution(test);
                Assert.AreEqual(expected, actual, "input: {" + String.Join(", ", test) + "}");
            }

            Console.WriteLine("Random tests passed!\nTotal user code execution time was {0}ms over {1} assertions",
                sw.Elapsed.TotalMilliseconds, tests);
        }
    }
}