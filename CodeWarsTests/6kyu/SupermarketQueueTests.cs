using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SupermarketQueueTests
    {
        [Test]
        public void ExampleTest1()
        {
            long expected = 0;

            long actual = SupermarketQueue.QueueTime(new int[] { }, 1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest2()
        {
            long expected = 10;

            long actual = SupermarketQueue.QueueTime(new int[] {1, 2, 3, 4}, 1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest3()
        {
            long expected = 9;

            long actual = SupermarketQueue.QueueTime(new int[] {2, 2, 3, 3, 4, 4}, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest4()
        {
            long expected = 5;

            long actual = SupermarketQueue.QueueTime(new int[] {1, 2, 3, 4, 5}, 100);

            Assert.AreEqual(expected, actual);
        }
    }
}