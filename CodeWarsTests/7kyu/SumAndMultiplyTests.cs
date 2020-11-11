using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataSumAndMultiplyTests
    {
        private static object[] testCases = new object[]
        {
            new object[] {13, 12, new int[] {1, 12}},
            new object[] {6, 9, new int[] {3, 3}},
            new object[] {200, 8458, null},
            new object[] {15, 56, new int[] {7, 8}},
        };

        [Test, TestCaseSource("testCases")]
        public void Test(int sum, int multiply, int[] expected) =>
            Assert.AreEqual(expected, KataSumAndMultiply.SumAndMultiply(sum, multiply));
    }
}