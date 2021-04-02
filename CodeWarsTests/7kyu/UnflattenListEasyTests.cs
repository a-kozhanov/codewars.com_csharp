using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class UnflattenListEasyTests
    {
        [Test]
        public void BasicTests()
        {
            var input = new int[] {3, 5, 2, 1};
            var expected = new object[] {new int[] {3, 5, 2}, 1};
            Assert.AreEqual(expected, UnflattenListEasy.Unflatten(input));

            input = new int[] {1, 4, 5, 2, 1, 2, 4, 5, 2, 6, 2, 3, 3};
            expected = new object[] {1, new int[] {4, 5, 2, 1}, 2, new int[] {4, 5, 2, 6}, 2, new int[] {3, 3}};
            Assert.AreEqual(expected, UnflattenListEasy.Unflatten(input));
        }
    }
}