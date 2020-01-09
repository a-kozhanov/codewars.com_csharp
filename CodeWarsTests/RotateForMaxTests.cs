using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RotateForMaxTests
    {
        private static void testing(long actual, long expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests");
            testing(RotateForMax.MaxRot(38458215), 85821534);
            testing(RotateForMax.MaxRot(195881031), 988103115);
            testing(RotateForMax.MaxRot(896219342), 962193428);
            testing(RotateForMax.MaxRot(69418307), 94183076);
        }
    }
}