using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;


namespace CodeWarsTests
{
    [TestFixture]
    public class MinMaxTests
    {

        [Test]
        public static void BasicTest()
        {
            Assert.AreEqual(new int[] { -1, 20 }, MinMax.minMax(new int[] { 1, 2, 5, -1, 12, 20 }));
            Assert.AreEqual(new int[] { 1, 5 },  MinMax.minMax(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -3, 5 },  MinMax.minMax(new int[] { 1, 2, -3, 4, 5 }));
            Assert.AreEqual(new int[] { -5, 9 },  MinMax.minMax(new int[] { 1, 9, 3, 4, -5 }));
            Assert.AreEqual(new int[] { -214, 542 },  MinMax.minMax(new int[] { 4, 5, 29, 54, 4, 0, -214, 542, -64, 1, -3, 6, -6 }));
            Assert.AreEqual(new int[] { 4, 4 },  MinMax.minMax(new int[] { 4 }));
        }


        [Test]
        public static void RandomTestArrayOneElement()
        {
            Random random = new Random();
            int rn = random.Next(1, 500);
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(new int[] { rn, rn },  MinMax.minMax(new int[] { rn }));
            }
        }


        private static int[] comb(int k)
        {
            Random random = new Random();
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
            {
                int x = random.Next(1, 10000);
                int y = random.Next(17, 29);
                int sgn = random.Next(0, 10);
                if (sgn == 0)
                    x = -x;
                res[i] = x * y;
            }
            return res;
        }

        private static int[] minMaxSol(int[] lst)
        {
            return new int[] { lst.Min(), lst.Max() };
        }


        [Test]
        public static void RandomTestBiggerArrays()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int[] lst = comb(random.Next(10, 50));
                //Console.WriteLine("minMax test number: " + i);
                Assert.AreEqual(MinMaxTests.minMaxSol(lst),  MinMax.minMax(lst));
            }
        }

    }

}
