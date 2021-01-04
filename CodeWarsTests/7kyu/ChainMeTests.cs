using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ChainMeTests
    {
        public static double add(double x)
        {
            return x + 10;
        }

        public static double mul(double x)
        {
            return x * 30;
        }

        [Test]
        public static void ExampleTest()
        {
            Assert.AreEqual(ChainMe.Chain(2, new[] {(Func<double, double>) add, mul}), 360, "Incorrect Value for '2'");
        }
    }
}