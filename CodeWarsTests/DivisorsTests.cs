using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DivisorsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(1, Divisors.divisors(1));
            Assert.AreEqual(4, Divisors.divisors(10));
            Assert.AreEqual(2, Divisors.divisors(11));
            Assert.AreEqual(8, Divisors.divisors(54));
        }

        private static Random rnd = new Random();

        private static int Solution(int n)
        {
            int count = 0;
            double sqrt = Math.Sqrt(n);
            for (int i = 1; i <= sqrt; ++i)
            {
                if (n % i == 0) count += 2;
                if (i == sqrt) --count;
            }
            return count;
        }

        [Test]
        public void SampleTest2()
        {
            Action[] tests = new Action[]
            {
                () => Assert.AreEqual(1, Divisors.divisors(1)),
                () => Assert.AreEqual(4, Divisors.divisors(10)),
                () => Assert.AreEqual(2, Divisors.divisors(11)),
                () => Assert.AreEqual(8, Divisors.divisors(54)),
            };
            tests.OrderBy(x => rnd.Next()).ToList().ForEach(a => a.Invoke());
        }

        [Test]
        public void RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                int test = rnd.Next(0, 500000);
                int expected = Solution(test);
                int actual = Divisors.divisors(test);
                Console.WriteLine("Testing:  {0}\nExpected: {1}\nActual:   {2}\n", test, expected, actual);
                Assert.AreEqual(expected, actual);
            }
        }
        /*
        [Test]
        public void LargeNumberRandomTest()
        {
          for (int i = 0; i < 1000; ++i)
          {
            int test = 2147483647 - rnd.Next(0, 5000000);
            int expected = Solution(test);
            int actual = Divisors.divisors(test);
            Console.WriteLine("Testing:  {0}\nExpected: {1}\nActual:   {2}\n", test, expected, actual);
            Assert.AreEqual(expected, actual);
          }
        }
        */

    }
}