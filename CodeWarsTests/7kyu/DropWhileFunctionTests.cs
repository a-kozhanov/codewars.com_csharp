using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DropWhileFunctionTests
    {
        private Func<int, bool> isEven = (value) => value % 2 == 0;

        [Test]
        public void BasicTest1()
        {
            var expected = new int[] {1, 5, 4, 3};
            var actual = DropWhileFunction.DropWhile(new int[] {2, 6, 4, 10, 1, 5, 4, 3}, isEven);

            Assert.AreEqual(string.Join(", ", expected), string.Join(", ", actual));
        }

        [Test]
        public void BasicTest2()
        {
            var expected = new int[] {5, 3, 4, 6};
            var actual = DropWhileFunction.DropWhile(new int[] {2, 100, 1000, 10000, 5, 3, 4, 6}, isEven);

            Assert.AreEqual(string.Join(", ", expected), string.Join(", ", actual));
        }

        [Test]
        public void BasicTest3()
        {
            var expected = new int[] { };
            var actual = DropWhileFunction.DropWhile(new int[] {2, 4, 10, 100, 64, 78, 92}, isEven);

            Assert.AreEqual(string.Join(", ", expected), string.Join(", ", actual));
        }
    }
}