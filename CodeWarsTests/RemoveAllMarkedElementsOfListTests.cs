using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RemoveAllMarkedElementsOfListTests
    {
        [Test]
        [TestCase(new int[] {1, 1, 2, 3, 1, 2, 3, 4}, new int[] {1, 3}, ExpectedResult = new int[] {2, 2, 4})]
        [TestCase(new int[] {1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8}, new int[] {1, 3, 4, 2},
            ExpectedResult = new int[] {5, 6, 7, 8})]
        [TestCase(new int[] { }, new int[] {2, 2, 4, 3}, ExpectedResult = new int[] { })]
        public static int[] FixedTest(int[] integerList, int[] valuesList)
        {
            return RemoveAllMarkedElementsOfList.Remove(integerList, valuesList);
        }
    }
}