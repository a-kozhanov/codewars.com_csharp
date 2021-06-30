using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HerosRootTests
    {
        [Test]
        public static void test1()
        {
            Assert.AreEqual(4, HerosRoot.IntRac(25, 1));
            Assert.AreEqual(3, HerosRoot.IntRac(125348, 300));
        }
    }
}