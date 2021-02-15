using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BinaryOperations1Tests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(7, BinaryOperations1.FlipBit(15, 4));
        }

        [Test]
        public void test2()
        {
            Assert.AreEqual(1, BinaryOperations1.FlipBit(0, 1));
        }

        [Test]
        public void test3()
        {
            Assert.AreEqual(14, BinaryOperations1.FlipBit(15, 1));
        }
    }
}