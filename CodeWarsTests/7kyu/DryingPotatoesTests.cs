using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DryingPotatoesTests
    {
        private static void dotest(int p0, int w0, int p1, int expected)
        {
            Assert.AreEqual(expected, DryingPotatoes.Potatoes(p0, w0, p1));
        }

        [Test]
        public static void test()
        {
            Console.WriteLine("Fixed Tests: Potatoes");
            dotest(82, 127, 80, 114);
            dotest(93, 129, 91, 100);
        }
    }
}