using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PlayingWithDigitsTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, PlayingWithDigits.digPow(89, 1));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(-1, PlayingWithDigits.digPow(92, 1));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(51, PlayingWithDigits.digPow(46288, 3));
        }
    }
}