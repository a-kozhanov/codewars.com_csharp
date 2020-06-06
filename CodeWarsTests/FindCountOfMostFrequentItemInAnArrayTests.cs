using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindCountOfMostFrequentItemInAnArrayTests
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] {new int[] {3, -1, -1}, 2},
            new object[] {new int[] {3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3}, 5},
        };

        [Test, TestCaseSource(typeof(FindCountOfMostFrequentItemInAnArrayTests), "Basic_Test_Cases")]
        public void Basic_Test(int[] test, int expected)
        {
            Assert.AreEqual(expected, FindCountOfMostFrequentItemInAnArray.MostFrequentItemCount(test));
        }
    }
}