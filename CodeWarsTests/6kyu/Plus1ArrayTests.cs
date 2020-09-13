using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Plus1ArrayTests
    {
        [Test]
        public void Test1()
        {
            var num = new int[] {2, 3, 9};
            var newNum = new int[] {2, 4, 0};
            Assert.AreEqual(newNum, Plus1Array.UpArray(num));
        }

        [Test]
        public void Test2()
        {
            var num = new int[] {4, 3, 2, 5};
            var newNum = new int[] {4, 3, 2, 6};
            Assert.AreEqual(newNum, Plus1Array.UpArray(num));
        }
    }
}