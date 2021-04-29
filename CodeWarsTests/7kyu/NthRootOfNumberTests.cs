using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NthRootOfNumberTests
    {
        [Test]
        public static void Test1()
        {
            double actual = NthRootOfNumber.FindRoot(4, 2);
            Assert.AreEqual(2, actual, 1e-9);
        }

        [Test]
        public static void Test2()
        {
            double actual = NthRootOfNumber.FindRoot(8, 3);
            Assert.AreEqual(2, actual, 1e-9);
        }

        [Test]
        public static void Test3()
        {
            double actual = NthRootOfNumber.FindRoot(256, 4);
            Assert.AreEqual(4, actual, 1e-9);
        }

        [Test]
        public static void Test4()
        {
            double actual = NthRootOfNumber.FindRoot(9, 2);
            Assert.AreEqual(3, actual, 1e-9);
        }

        [Test]
        public static void Test5()
        {
            double actual = NthRootOfNumber.FindRoot(6.25, 2);
            Assert.AreEqual(2.5, actual, 1e-9);
        }
    }
}