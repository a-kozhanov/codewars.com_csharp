using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrowthOfPopulationTests
    {
        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing NbYear");
            testing(GrowthOfPopulation.NbYear(1500, 5, 100, 5000), 15);
            testing(GrowthOfPopulation.NbYear(1500000, 2.5, 10000, 2000000), 10);
            testing(GrowthOfPopulation.NbYear(1500000, 0.25, 1000, 2000000), 94);
        }
    }
}