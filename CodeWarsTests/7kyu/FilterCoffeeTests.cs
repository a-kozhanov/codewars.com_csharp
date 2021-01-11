using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FilterCoffeeTests
    {
        [Test]
        [TestCase(3, new int[] {6, 1, 2, 9, 2}, ExpectedResult = "1,2,2")]
        [TestCase(14, new int[] {7, 3, 23, 9, 14, 20, 7}, ExpectedResult = "3,7,7,9,14")]
        [TestCase(0, new int[] {6, 1, 2, 9, 2}, ExpectedResult = "")]
        public static string FixedTest(int budget, int[] prices)
        {
            return FilterCoffee.Search(budget, prices);
        }
    }
}