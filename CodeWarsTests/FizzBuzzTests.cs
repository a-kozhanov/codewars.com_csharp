using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private static object[] sampleTestCases = new object[]
        {
            new object[] {20, new int[] {5, 2, 1}},
            new object[] {2, new int[] {0, 0, 0}},
            new object[] {30, new int[] {8, 4, 1}},
            new object[] {300, new int[] {80, 40, 19}},
        };

        [Test, TestCaseSource("sampleTestCases")]
        public void SampleTest(int number, int[] expected)
        {
            Assert.AreEqual(expected, FizzBuzz.Solution(number));
        }

        private static Random rnd = new Random();

        private static int[] solution(int number) => new int[]
            {--number / 3 - number / 15, number / 5 - number / 15, number / 15};

        [Test]
        public void RandomTests()
        {
            for (int i = 0; i < 100; ++i)
            {
                int test = rnd.Next(1, 1000);
                int[] expected = solution(test);
                int[] actual = FizzBuzz.Solution(test);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}