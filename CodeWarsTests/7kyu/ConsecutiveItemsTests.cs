using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConsecutiveItemsTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(ConsecutiveItems.Consecutive(new int[]{1, 3, 5, 7}, 3, 7), false);
            Assert.AreEqual(ConsecutiveItems.Consecutive(new int[]{1, 3, 5, 7}, 3, 1), true);
            Assert.AreEqual(ConsecutiveItems.Consecutive(new int[]{1, 6, 9, -3, 4, -78, 0}, -3, 4), true);
        }
    }
}