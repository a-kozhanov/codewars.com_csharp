using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsDivisibleByXAndYTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, IsDivisibleByXAndY.isDivisible(12, 4, 3));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, IsDivisibleByXAndY.isDivisible(3, 3, 4));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, IsDivisibleByXAndY.isDivisible(8, 3, 4));
        }
    }
}