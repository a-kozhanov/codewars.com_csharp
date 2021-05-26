using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DescendingOrderTests
    {
        [Test]
        public void Test0()
        {
            Assert.AreEqual(0, KataDescendingOrder.DescendingOrder(0));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, KataDescendingOrder.DescendingOrder(1));
        }

        [Test]
        public void Test15()
        {
            Assert.AreEqual(51, KataDescendingOrder.DescendingOrder(15));
        }

        [Test]
        public void Test1021()
        {
            Assert.AreEqual(2110, KataDescendingOrder.DescendingOrder(1021));
        }

        [Test]
        public void Test123456789()
        {
            Assert.AreEqual(987654321, KataDescendingOrder.DescendingOrder(123456789));
        }
    }
}