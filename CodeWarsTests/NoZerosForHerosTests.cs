using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NoZerosForHerosTests
    {
        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests NoBoringZeros");
            testing(NoZerosForHeros.NoBoringZeros(1450), 145);
            testing(NoZerosForHeros.NoBoringZeros(960000), 96);
            testing(NoZerosForHeros.NoBoringZeros(1050), 105);
            testing(NoZerosForHeros.NoBoringZeros(-1050), -105);
        }
    }
}