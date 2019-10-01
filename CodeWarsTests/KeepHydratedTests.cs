using System;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KeepHydratedTests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(1, KeepHydrated.Litres(2));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(0, KeepHydrated.Litres(1.4));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(6, KeepHydrated.Litres(12.3));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual(0, KeepHydrated.Litres(0.82));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual(5, KeepHydrated.Litres(11.8));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual(893, KeepHydrated.Litres(1787));
        }
        [Test]
        public static void Test7()
        {
            Assert.AreEqual(0, KeepHydrated.Litres(0));
        }

        public static Random rng = new Random();

        [Test]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(1.4, ExpectedResult = 0)]
        [TestCase(12.3, ExpectedResult = 6)]
        [TestCase(0.82, ExpectedResult = 0)]
        [TestCase(11.8, ExpectedResult = 5)]
        [TestCase(1787, ExpectedResult = 893)]
        [TestCase(0, ExpectedResult = 0)]
        public static int FixedTest(double d)
        {
            return KeepHydrated.Litres(d);
        }

        [Test]
        public static void RandomTest([Random(0, 10000, 100)] double d)
        {
            Assert.AreEqual((int)(d * 0.5), KeepHydrated.Litres(d));
        }


    }
}