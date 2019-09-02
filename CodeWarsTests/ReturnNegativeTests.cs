using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReturnNegativeTests
    {
        Random r = new Random();

        [Test]
        public void PositiveTest()
        {
            Assert.AreEqual(-42, ReturnNegative.MakeNegative(42));
        }

        [Test]
        public void NegativeTest()
        {
            Assert.AreEqual(-9, ReturnNegative.MakeNegative(-9));
        }

        [Test]
        public void ZeroTest()
        {
            Assert.AreEqual(0, ReturnNegative.MakeNegative(0));
        }

        [Test]
        public void OneTest()
        {
            Assert.AreEqual(-1, ReturnNegative.MakeNegative(1));
        }

        [Test]
        public void NegativeOneTest()
        {
            Assert.AreEqual(-1, ReturnNegative.MakeNegative(-1));
        }

        [Test]
        public void RandomPositiveTest()
        {
            int number = r.Next(1, 101);
            Assert.AreEqual(-Math.Abs(number), ReturnNegative.MakeNegative(number));
        }

        [Test]
        public void RandomNegativeTest()
        {
            int number = r.Next(-100, 0);
            Assert.AreEqual(-Math.Abs(number), ReturnNegative.MakeNegative(number));
        }
    }
}