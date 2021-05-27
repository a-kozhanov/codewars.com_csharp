using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReverseListTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new int[0], ReverseList.reverseList(new int[0]));
            Assert.AreEqual(new int[] {3, 2, 1}, ReverseList.reverseList(new int[] {1, 2, 3}));
        }
    }
}