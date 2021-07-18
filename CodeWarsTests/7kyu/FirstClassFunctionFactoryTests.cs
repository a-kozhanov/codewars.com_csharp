using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FirstClassFunctionFactoryTests
    {
        private static void testing(int[] expected, int[] actual)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void BasicTest()
        {
            Func<int[], int[]> threes = FirstClassFunctionFactory.factory(3);
            int[] myArr = new int[] {1, 2, 3};
            testing(threes(myArr), new int[] {3, 6, 9});

            Func<int[], int[]> fives = FirstClassFunctionFactory.factory(5);
            testing(fives(myArr), new int[] {5, 10, 15});
        }
    }
}