using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AddingValuesOfArraysInShiftedWayTests
    {
        [Test]
        public void BasicTests()
        {
            var arrayOfArrays = new int[][] {new int[] {1, 2, 3, 4, 5, 6}, new int[] {7, 7, 7, 7, 7, -7}};
            var expected = new int[] {8, 9, 10, 11, 12, -1};
            var result = AddingValuesOfArraysInShiftedWay.AddingShifted(arrayOfArrays, 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(string.Join(",", expected), string.Join(",", result));

            arrayOfArrays = new int[][] {new int[] {1, 2, 3, 4, 5, 6}, new int[] {7, 7, 7, 7, 7, 7}};
            expected = new int[] {1, 2, 3, 11, 12, 13, 7, 7, 7};
            result = AddingValuesOfArraysInShiftedWay.AddingShifted(arrayOfArrays, 3);
            Assert.IsNotNull(result);
            Assert.AreEqual(string.Join(",", expected), string.Join(",", result));

            arrayOfArrays = new int[][]
                {new int[] {1, 2, 3, 4, 5, 6}, new int[] {7, 7, 7, -7, 7, 7}, new int[] {1, 1, 1, 1, 1, 1}};
            expected = new int[] {1, 2, 3, 11, 12, 13, -6, 8, 8, 1, 1, 1};
            result = AddingValuesOfArraysInShiftedWay.AddingShifted(arrayOfArrays, 3);
            Assert.IsNotNull(result);
            Assert.AreEqual(string.Join(",", expected), string.Join(",", result));
        }
    }
}