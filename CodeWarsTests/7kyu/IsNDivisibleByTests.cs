using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsNDivisibleByTests
    {
        [Test]
        public void BasicTest1()
        {
            Assert.AreEqual(false, IsNDivisibleBy.IsDivisible(3, 3, 4));
        }

        [Test]
        public void BasicTest2()
        {
            Assert.AreEqual(true, IsNDivisibleBy.IsDivisible(12, 3, 4));
        }
    }
}