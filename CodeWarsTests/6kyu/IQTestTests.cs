using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IQTestTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, IQTest.Test("2 4 7 8 10"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, IQTest.Test("1 2 2"));
        }
    }
}