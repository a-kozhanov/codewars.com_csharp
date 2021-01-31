using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GoingToCinemaTests
    {
        private static void testing(long actual, long expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Fixed Tests: Movie");
            testing(GoingToCinema.Movie(500, 15, 0.9), 43);
            testing(GoingToCinema.Movie(100, 10, 0.95), 24);
        }
    }
}