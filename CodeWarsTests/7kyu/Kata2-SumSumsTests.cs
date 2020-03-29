using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Kata2_SumSumsTests
    {
        [TestFixture]
        public class AccountTest
        {
            [Test]
            public void ValueTest1()
            {
                Kata2_SumSums t = new Kata2_SumSums();
                var res = t.SumOfTwoSumTargets(new[] {1, 2, 3, 4}, 3, 4);
                Assert.AreEqual(3, res);
            }

            [Test]
            public void ValueTest2()
            {
                Kata2_SumSums t = new Kata2_SumSums();
                var res = t.SumOfTwoSumTargets(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 3, 10);
                Assert.AreEqual(42, res);
            }

            [Test]
            public void ValueTest3()
            {
                Kata2_SumSums t = new Kata2_SumSums();
                var res = t.SumOfTwoSumTargets(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 1000, 1001);
                Assert.AreEqual(0, res);
            }

            //[Test, Timeout(1500)]
            [Test, Timeout(500)]
            public void PerfomanceTest()
            {
                Kata2_SumSums t = new Kata2_SumSums();
                int N = 10000;
                int[] array = new int[N];

                for (int i = 0; i < N; i++)
                {
                    array[i] = i * 7;
                }

                var res = t.SumOfTwoSumTargets(array, 0, 2000);
                Assert.AreEqual(285285, res);
            }

            [Test, Timeout(500)]
            public void PerfomanceRandomTest()
            {
                Kata2_SumSums t = new Kata2_SumSums();
                TwoSumTest exp = new TwoSumTest();
                Random r = new Random();
                int N = 10000;
                int[] array = new int[N];

                for (int i = 0; i < N; i++)
                {
                    array[i] = r.Next(i * 7 - 7, i * 7);
                }

                var actRes = t.SumOfTwoSumTargets(array, 0, 2000);
                var expRes = exp.SumOfTwoSumTargets(array, 0, 2000);
                Assert.AreEqual(expRes, actRes);
            }

            [Test]
            public void RandomTest()
            {
                Kata2_SumSums t = new Kata2_SumSums();
                TwoSumTest exp = new TwoSumTest();
                Random r = new Random();
                int N = 50;
                int[] array = new int[N];

                for (int i = 0; i < N; i++)
                {
                    array[i] = r.Next(i * 7 - 7, i * 7);
                }

                var actRes = t.SumOfTwoSumTargets(array, 100, 500);
                var expRes = exp.SumOfTwoSumTargets(array, 100, 500);
                Assert.AreEqual(expRes, actRes);
            }
        }

        public class TwoSumTest
        {
            public HashSet<int> set = new HashSet<int>();

            public int SumOfTwoSumTargets(int[] numbers, int from, int to)
            {
                set = new HashSet<int>(numbers);

                int sum = 0;
                for (int i = from; i < to; i++)
                {
                    if (TwoSumContains(numbers, i))
                    {
                        sum += i;
                    }
                }

                return sum;
            }

            public bool TwoSumContains(int[] numbers, int target)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (target - numbers[i] == numbers[i])
                        continue;

                    if (set.Contains(target - numbers[i]))
                        return true;
                }

                return false;
            }
        }
    }
}