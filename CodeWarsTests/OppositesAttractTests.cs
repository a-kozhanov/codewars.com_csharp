using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OppositesAttractTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, OppositesAttract.lovefunc(1, 4));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, OppositesAttract.lovefunc(2, 2));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(true, OppositesAttract.lovefunc(0, 1));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, OppositesAttract.lovefunc(0, 0));
        }
    }
}