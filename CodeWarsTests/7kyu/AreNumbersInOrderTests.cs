using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AreNumbersInOrderTests
    {
        [Test]
        [TestCase(new int[] {1, 2}, ExpectedResult = true)]
        [TestCase(new int[] {2, 1}, ExpectedResult = false)]
        [TestCase(new int[] {1, 2, 3}, ExpectedResult = true)]
        [TestCase(new int[] {1, 3, 2}, ExpectedResult = false)]
        [TestCase(new int[] {2, 1, 3}, ExpectedResult = false)]
        [TestCase(new int[] {2, 3, 1}, ExpectedResult = false)]
        [TestCase(new int[] {3, 1, 2}, ExpectedResult = false)]
        [TestCase(new int[] {3, 2, 1}, ExpectedResult = false)]
        public static bool BasicFixedTest(int[] arr)
        {
            return AreNumbersInOrder.IsAscOrder(arr);
        }

        [Test]
        [TestCase(new int[] {1, 4, 13, 97, 508, 1047, 20058}, ExpectedResult = true)]
        [TestCase(new int[] {56, 98, 123, 67, 742, 1024, 32, 90969}, ExpectedResult = false)]
        public static bool AdvancedFixedTest(int[] arr)
        {
            return AreNumbersInOrder.IsAscOrder(arr);
        }
    }
}