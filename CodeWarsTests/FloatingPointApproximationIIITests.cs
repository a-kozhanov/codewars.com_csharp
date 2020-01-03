using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    public class FloatingPointApproximationIIITests
    {
        private static Random rnd = new Random();

        private static void assertFuzzyEquals(double a, double b, double c)
        {
            double merr = 1e-12;

            Console.WriteLine("Testing " + a + ", " + b.ToString("e2") + ", " + c);

            double x = FloatingPointApproximationIII.Quadratic(a, b, c);

            bool smallest = Math.Abs(x) < 1e-1;

            if (smallest == false)
                Console.WriteLine("This root is not the good one");

            double actual = a * x * x + b * x + c;

            bool inrange = Math.Abs(actual) <= merr;

            if (inrange == false)
                Console.WriteLine("Expected must be near " + 0.0 + ", got " + actual.ToString("e12"));

            bool correct = smallest && inrange;

            Assert.AreEqual(true, correct);
        }

        [Test]
        public static void test()
        {
            Console.WriteLine("Fixed Tests: quadratic");
            assertFuzzyEquals(7, 4.00e+13, 8);
            assertFuzzyEquals(9, 1.00e+14, 1);
            assertFuzzyEquals(3, 3.00e+09, 1);
            assertFuzzyEquals(7, 4.00e+09, 7);
        }
    }
}