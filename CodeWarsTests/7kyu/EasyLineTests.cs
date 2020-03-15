using System;
using System.Numerics;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataEasyLineTests
    {
        private static void testing(BigInteger actual, BigInteger expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test()
        {
            Console.WriteLine("Fixed Tests");
            testing(KataEasyLine.EasyLine(7), BigInteger.Parse("3432"));
            testing(KataEasyLine.EasyLine(13), BigInteger.Parse("10400600"));
            testing(KataEasyLine.EasyLine(17), BigInteger.Parse("2333606220"));
            testing(KataEasyLine.EasyLine(19), BigInteger.Parse("35345263800"));
        }
    }
}