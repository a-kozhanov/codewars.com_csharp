using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WhereIsVasyaTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, WhereIsVasya.WhereIsHe(3, 1, 1));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(3, WhereIsVasya.WhereIsHe(5, 2, 3));
        }
    }
}