using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NthPowerRulesThemAllTests
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] {new int[] {1, 2, 3}, 3, 30},
            new object[] {new int[] {1, 2}, 5, 30},
        };

        [Test, TestCaseSource(typeof(NthPowerRulesThemAllTests), nameof(Basic_Test_Cases))]
        public void Basic_Test(int[] array, int exponent, int expected)
        {
            Assert.AreEqual(expected, NthPowerRulesThemAll.ModifiedSum(array, exponent),
                "Solution should work for the examples provided in the Description");
        }
    }
}