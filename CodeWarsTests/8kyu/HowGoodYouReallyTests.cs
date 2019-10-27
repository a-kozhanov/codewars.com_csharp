using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    class HowGoodYouReallyTests
    {
        [Test]
        [TestCase(new int[] { 2, 3 }, 5, ExpectedResult = true)]
        [TestCase(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, ExpectedResult = true)]
        [TestCase(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, ExpectedResult = true)]
        public static bool FixedTest(int[] arr, int num)
        {
            return HowGoodYouReally.BetterThanAverage(arr, num);
        }
    }
}
