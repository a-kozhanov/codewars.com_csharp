using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleRemoveDuplicatesTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new int[] {4, 6, 3}, SimpleRemoveDuplicates.solve(new int[] {3, 4, 4, 3, 6, 3}));
            Assert.AreEqual(new int[] {1, 2, 3}, SimpleRemoveDuplicates.solve(new int[] {1, 2, 1, 2, 1, 2, 3}));
            Assert.AreEqual(new int[] {1, 2, 3, 4}, SimpleRemoveDuplicates.solve(new int[] {1, 2, 3, 4}));
            Assert.AreEqual(new int[] {4, 5, 2, 1}, SimpleRemoveDuplicates.solve(new int[] {1, 1, 4, 5, 1, 2, 1}));
        }
    }
}