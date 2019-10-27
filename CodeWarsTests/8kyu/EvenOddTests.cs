using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EvenOddTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Even", EvenOdd.EvenOrOdd(2));
            Assert.AreEqual("Odd", EvenOdd.EvenOrOdd(1));
            Assert.AreEqual("Even", EvenOdd.EvenOrOdd(0));
            Assert.AreEqual("Odd", EvenOdd.EvenOrOdd(7));
            Assert.AreEqual("Odd", EvenOdd.EvenOrOdd(-1));
        }
    }
}